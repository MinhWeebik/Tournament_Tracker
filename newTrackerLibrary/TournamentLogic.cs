﻿using newTrackerLibrary.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace newTrackerLibrary
{
    public static class TournamentLogic
    {
        //Sắp xếp danh sách random
        //Kiểm tra xem nó có đủ to không - nếu không thêm byes vào - 2^n
        //Tạo các vòng đầu
        //Tạo các vòng sau đó - 8 matchups - 4 matchups - 2 matchups - 1 matchups
        public static void CreateRounds(TournamentModel model)
        {
            List<TeamModel> randomizedTeams = RandomizeTeamOrder(model.EnteredTeams);
            int rounds = FindNumberOfRounds(randomizedTeams.Count);
            int byes = NumberOfByes(rounds, randomizedTeams.Count);
            model.Rounds.Add(CreateFirstRound(byes, randomizedTeams));
            CreateOtherRounds(model, rounds);
        }

        public static void UpdateTournamentResult(TournamentModel model)
        {
            int startingRound = model.CheckCurrentRound();
            List<MatchupModel> toScore = new List<MatchupModel>();
            foreach (List<MatchupModel> round in model.Rounds)
            {
                foreach (MatchupModel rm in round)
                {
                    if(rm.Winner == null && (rm.Entries.Any(x => x.Score != 0) || rm.Entries.Count == 1))
                    {
                        toScore.Add(rm);
                    }
                }
            }

            MarkWinnerInMatchups(toScore);
            AdvanceWinners(toScore,model);
            toScore.ForEach(x => GlobalConfig.Connection.updateMatchup(x));
            int endingRound = model.CheckCurrentRound();
            if(endingRound > startingRound)
            {
                model.AlertUserToNewRound();
            }

        }

        public static void AlertUserToNewRound(this TournamentModel model)
        {
            int currentRoundNumber = model.CheckCurrentRound();
            List<MatchupModel> currentRound = model.Rounds.Where(x => x.First().MatchupRound == currentRoundNumber).First();
            foreach(MatchupModel matchup in currentRound)
            {
                foreach(MatchupEntryModel me in matchup.Entries)
                {
                    foreach(PersonModel p in me.TeamCompeting.TeamMembers)
                    {
                        AlertPersonToNewRound(p, me.TeamCompeting.TeamName,matchup.Entries.Where(x => x.TeamCompeting != me.TeamCompeting).FirstOrDefault());
                    }
                }
            }
        }

        private static void AlertPersonToNewRound(PersonModel p, string teamName, MatchupEntryModel competitor)
        {
            string to = "";
            string subject = "";
            StringBuilder body = new StringBuilder();
            if(competitor != null)
            {
                subject = $"Bạn có một trận đấu mới với {competitor.TeamCompeting.TeamName}";
                body.AppendLine("<h1>Bạn có một trận đấu mới</h1>");
                body.Append("<strong>Đối thủ: </strong>");
                body.Append(competitor.TeamCompeting.TeamName);
                body.AppendLine();
                body.AppendLine();
                body.AppendLine("Chúc vui vẻ");
                body.AppendLine("~Tournament Tracker");
               
            }
            else
            {
                subject = "Bạn được qua vòng loại";
                body.AppendLine("Bạn được qua vòng loại");
                body.AppendLine("~Tournament Tracker");
            }
            to = p.EmailAddress;
            EmailLogic.sendEmail(to, subject, body.ToString());
        }

        public static void CheckIfComplete(TournamentModel model)
        {
            bool output = false;
            int roundFinished = 0;
            foreach(List<MatchupModel> round in model.Rounds)
            {
                if(round.All(x => x.Winner != null))
                {
                    roundFinished += 1;
                }
            }
            if(roundFinished == CheckCurrentRound(model))
            {
                output = true;
            }
            if(output)
            {
                CompleteTournament(model);
            }

        }

        public static int CheckCurrentRound(this TournamentModel model)
        {
            int output = 1;
            foreach(List<MatchupModel> round in model.Rounds)
            {
                if(round.All(x => x.Winner!= null))
                {
                    output += 1;
                }
                else
                {
                    return output;
                }
            }
            return output - 1;
        }

        private static void CompleteTournament(TournamentModel model)
        {
            GlobalConfig.Connection.completeTouranment(model);
            TeamModel winners = model.Rounds.Last().First().Winner;
            TeamModel runnerUp = model.Rounds.Last().First().Entries.Where(x => x.TeamCompeting != winners).First().TeamCompeting;

            decimal winnerPrize = 0;
            decimal runnerUpPrize = 0;

            if(model.Prizes.Count > 0)
            {
                decimal totalIncome = model.EnteredTeams.Count * model.EntryFee;

                PrizeModel firstPlacePrize = model.Prizes.Where(x => x.PlaceNumber == 1).FirstOrDefault();
                PrizeModel secondPlacePrize = model.Prizes.Where(x => x.PlaceNumber == 2).FirstOrDefault();
                if (firstPlacePrize != null)
                {
                    winnerPrize = firstPlacePrize.CalculatePrizePayout(totalIncome);
                }
                if(secondPlacePrize != null)
                {
                    runnerUpPrize = secondPlacePrize.CalculatePrizePayout(totalIncome);
                }
            }
            string subject = "";
            StringBuilder body = new StringBuilder();

            subject = $"Trong {model.TournamentName}, {winners.TeamName} là đội thắng cuộc!";
            body.AppendLine("<h1>Đã có đội chiền thắng!</h1>");
            body.AppendLine("<p>Chúc mừng đội thắng cuộc và cảm ơn mọi người đã tham gia.</p>");
            body.AppendLine("<br/>");
            if(winnerPrize > 0)
            {
                body.AppendLine($"<p>{winners.TeamName} sẽ nhận được VND{winnerPrize}</p>"); 
            }
            else
            {
                body.AppendLine($"<p>{winners.TeamName} là đội chiến thắng</p>");
            }
            if (runnerUpPrize > 0)
            {
                body.AppendLine($"<p>{runnerUp.TeamName} sẽ nhận được VND{runnerUpPrize}</p>");
            }
            else
            {
                body.AppendLine($"<p>{runnerUp.TeamName} là đội về nhì</p>");
            }
            body.AppendLine("<p>Cảm ơn mọi người vì một giải đấu tuyệt vời!</p>");
            body.AppendLine("~Tournament Tracker");
            List<string> bcc = new List<string>();
            foreach (TeamModel t in model.EnteredTeams)
            {
                foreach(PersonModel p in t.TeamMembers)
                {
                    bcc.Add(p.EmailAddress);
                }
            }
            EmailLogic.sendEmail(new List<string>(),bcc, subject, body.ToString());
            model.CompleteTournament();
        }

        public static void SendTournamentCancelEmail(TournamentModel model)
        {
            string subject = "";
            StringBuilder body = new StringBuilder();

            subject = $"Giải đấu {model.TournamentName} đã bị hủy";
            body.AppendLine("<h1>Giải đấu đã bị hủy</h1>");
            body.AppendLine("<p>Xin lỗi những đội đã tham gia</p>");
            body.AppendLine("<br/>");
            body.AppendLine("<p>Các đội sẽ được hoàn lại phí tham gia</p>");
            body.AppendLine("<p>Cảm ơn mọi người vì đã thông cảm</p>");
            body.AppendLine("~Tournament Tracker");
            List<string> bcc = new List<string>();
            foreach (TeamModel t in model.EnteredTeams)
            {
                foreach (PersonModel p in t.TeamMembers)
                {
                    bcc.Add(p.EmailAddress);
                }
            }
            EmailLogic.sendEmail(new List<string>(), bcc, subject, body.ToString());
        }

        private static decimal CalculatePrizePayout(this PrizeModel prize, decimal totalIncome)
        {
            decimal output = 0;
            if(prize.PrizeAmount > 0)
            {
                output = prize.PrizeAmount;
            }
            else
            {
                output = Decimal.Multiply(totalIncome,Convert.ToDecimal(prize.PrizePercentage / 100));
            }
            return output;
        }

        private static void AdvanceWinners(List<MatchupModel> models,TournamentModel tournament)
        {
            foreach (MatchupModel m in models)
            {
                foreach (List<MatchupModel> round in tournament.Rounds)
                {
                    foreach (MatchupModel rm in round)
                    {
                        foreach (MatchupEntryModel me in rm.Entries)
                        {
                            if (me.ParentMatchup != null)
                            {
                                if (me.ParentMatchup.Id == m.Id)
                                {
                                    me.TeamCompeting = m.Winner;
                                    GlobalConfig.Connection.updateMatchup(rm);
                                }
                            }
                        }
                    }
                }
            }
        }

        private static void MarkWinnerInMatchups(List<MatchupModel> models)
        {
            foreach(MatchupModel m in models)
            {
                if(m.Entries.Count ==1)
                {
                    m.Winner = m.Entries[0].TeamCompeting;
                    continue;
                }
                if (m.Entries[0].Score > m.Entries[1].Score)
                {
                    m.Winner = m.Entries[0].TeamCompeting;
                }
                else if(m.Entries[0].Score < m.Entries[1].Score)
                {
                    m.Winner = m.Entries[1].TeamCompeting;
                }
                else
                {
                    throw new Exception("Không cho phép hòa trong ứng dụng này");
                }
            }
        }

        private static void CreateOtherRounds(TournamentModel model,int rounds)
        {
            int round = 2;
            List<MatchupModel> previousRound = model.Rounds[0];
            List<MatchupModel> currRound = new List<MatchupModel>();
            MatchupModel currMatchup = new MatchupModel();
            while(round <= rounds)
            {
                foreach(MatchupModel matchup in previousRound)
                {
                    currMatchup.Entries.Add(new MatchupEntryModel { ParentMatchup =  matchup });
                    if(currMatchup.Entries.Count > 1)
                    {
                        currMatchup.MatchupRound = round;
                        currRound.Add(currMatchup);
                        currMatchup = new MatchupModel();
                    }
                }
                model.Rounds.Add(currRound);
                previousRound = currRound;
                currRound = new List<MatchupModel>();
                round += 1;
            }
        }

        private static List<MatchupModel> CreateFirstRound(int byes, List<TeamModel> teams)
        {
            List<MatchupModel> output = new List<MatchupModel>();
            MatchupModel curr = new MatchupModel();
            foreach (TeamModel team in teams)
            {
                curr.Entries.Add(new MatchupEntryModel { TeamCompeting = team });
                if (byes > 0 || curr.Entries.Count > 1)
                {
                    curr.MatchupRound = 1;
                    output.Add(curr);
                    curr = new MatchupModel();
                    if(byes > 0)
                    {
                        byes -= 1;
                    }
                }
            }
            return output;
        }

        private static int NumberOfByes(int rounds, int numberOfTeams)
        {
            int output = 0;
            int totalTeams = 1;
            for(int i=1;i<=rounds;i++)
            {
                totalTeams *= 2;
            }
            return output = totalTeams - numberOfTeams;
        }
        private static int FindNumberOfRounds(int teamCount)
        {
            int output = 1;
            int val = 2;
            while(val < teamCount)
            {
                output += 1;
                val *= 2;
            }
            return output;
        }

        private static List<TeamModel> RandomizeTeamOrder(List<TeamModel> teams)
        {
            return teams.OrderBy(x => Guid.NewGuid()).ToList();
        }

        public static bool IsMatch(string input, string word)
        {
            return word.Contains(input);
        }
    
    }
}
