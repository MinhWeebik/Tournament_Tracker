﻿using newTrackerLibrary.Models;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Security.Permissions;
using System.Text;
using System.Threading.Tasks;

namespace newTrackerLibrary.DataAccess.TextHelper
{
    public static class TextConnectorProcessor
    {
        public static string FullFilePath(this string fileName)
        {
            return $"{ ConfigurationManager.AppSettings["filePath"]}\\{fileName}";
        }
        public static List<string> LoadFile(this string file)
        {
            if(!File.Exists(file))
            {
                return new List<string>();
            }
            return File.ReadAllLines(file).ToList();
        }
        public static List<PrizeModel> ConvertToPrizeModels(this List<string> lines)
        {
            List<PrizeModel> output = new List<PrizeModel>();
            foreach (string line in lines)
            {
                string[] cols = line.Split(',');
                PrizeModel p = new PrizeModel();
                p.Id = int.Parse(cols[0]);
                p.PlaceNumber = int.Parse(cols[1]);
                p.PlaceName = cols[2];
                p.PrizeAmount = decimal.Parse(cols[3]);
                p.PrizePercentage = double.Parse(cols[4]);
                output.Add(p);
            }
            return output;
        }

        public static List<PersonModel> ConvertToPersonModels(this List<string> lines)
        {
            List<PersonModel> output = new List<PersonModel>();
            foreach(string line in lines)
            {
                string[] cols = line.Split(',');
                PersonModel p = new PersonModel();
                p.Id = int.Parse(cols[0]);
                p.FirstName = cols[1];
                p.LastName = cols[2];
                p.EmailAddress = cols[3];
                p.CellphoneNumber = cols[4];
                output.Add(p);
            }
            return output;
        }

        public static List<TeamModel> ConvertToTeamModels(this List<string> lines, string peopleFileName)
        {
            List<TeamModel> output = new List<TeamModel>();
            List<PersonModel> people = peopleFileName.FullFilePath().LoadFile().ConvertToPersonModels();
            foreach (string line in lines)
            {
                string[] cols = line.Split(',');
                TeamModel t = new TeamModel();
                t.Id = int.Parse(cols[0]);
                t.TeamName = cols[1];

                string[] personIds = cols[2].Split('|');
                foreach( string id in personIds)
                {
                    //Tìm trong danh sách people xem có id nào giống với id trên không (dùng First() do c# trả về 1 danh sách)
                    t.TeamMembers.Add(people.Where(x => x.Id == int.Parse(id)).First());
                }
                output.Add(t);
            }
            return output;
        }

        public static List<TournamentModel> ConvertToTournamentModels(this List<string> lines, string teamFileName, string peopleFileName,string prizeFileName)
        {
            //id,tournamentName,entryFee,(id|id|id - enteredTeams),(id|id|id - prizes),(Rounds - id^id^id|id^id^id|id^id^id)
            List<TournamentModel> output = new List<TournamentModel>();
            List<TeamModel> teams = teamFileName.FullFilePath().LoadFile().ConvertToTeamModels(peopleFileName);
            List<PrizeModel> prizes = prizeFileName.FullFilePath().LoadFile().ConvertToPrizeModels();
            List<MatchupModel> matchups = GlobalConfig.MatchupFile.FullFilePath().LoadFile().ConvertToMatchupModel();
            foreach (string line in lines)
            {
                string[] cols = line.Split(',');
                TournamentModel tm = new TournamentModel();
                tm.Id = int.Parse(cols[0]);
                tm.TournamentName = cols[1];
                tm.EntryFee = decimal.Parse(cols[2]);

                string[] teamIds = cols[3].Split('|');
                foreach (string id in teamIds)
                {
                    //Tìm trong danh sách teams xem có id nào giống với id trên không (dùng First() do c# trả về 1 danh sách)
                    tm.EnteredTeams.Add(teams.Where(x => x.Id == int.Parse(id)).First());
                }

                if (cols[4].Length > 0)
                {
                    string[] prizeIds = cols[4].Split('|');
                    foreach (string id in prizeIds)
                    {

                        //Tìm trong danh sách prizes xem có id nào giống với id trên không (dùng First() do c# trả về 1 danh sách)
                        tm.Prizes.Add(prizes.Where(x => x.Id == int.Parse(id)).First());
                    } 
                }

                string[] rounds = cols[5].Split('|');
                foreach (string round in rounds)
                {
                    List<MatchupModel> ms = new List<MatchupModel>();
                    string[] msText = round.Split('^');
                    foreach(string matchupModelTextId in msText)
                    {
                        ms.Add(matchups.Where(x => x.Id == int.Parse(matchupModelTextId)).First());
                    }
                    tm.Rounds.Add(ms);
                }
                output.Add(tm);
            }
            return output;
        }

        public static void SaveToPrizeFile(this List<PrizeModel> models, string fileName)
        {
            List<string> lines = new List<string>();
            foreach(PrizeModel p in models)
            {
                lines.Add($"{p.Id},{p.PlaceNumber},{p.PlaceName},{p.PrizeAmount},{p.PrizePercentage}");
            }

            File.WriteAllLines(fileName.FullFilePath(), lines);
        }

        public static void SaveToPeopleFile(this List<PersonModel> models, string fileName)
        {
            List<string> lines = new List<string>();
            foreach(PersonModel p in models)
            {
                lines.Add($"{p.Id},{p.FirstName},{p.LastName},{p.EmailAddress},{p.CellphoneNumber}");
            }
            File.WriteAllLines(fileName.FullFilePath(), lines);
        }

        public static void SaveToTeamFile(this List<TeamModel> models, string fileName)
        {
            List<string> lines = new List<string>();
            foreach (TeamModel t in models)
            {
                lines.Add($"{t.Id},{t.TeamName},{convertPeopleListToString(t.TeamMembers)}");
            }
            File.WriteAllLines(fileName.FullFilePath(), lines);
        }

        public static List<MatchupEntryModel> ConvertToMatchupEntryModel(this List<string> lines)
        {
            List<MatchupEntryModel> output = new List<MatchupEntryModel> ();
            foreach(string line in lines)
            {
                string[] cols = line.Split(',');
                MatchupEntryModel me = new MatchupEntryModel ();
                me.Id = int.Parse(cols[0]);
                if (cols[1].Length == 0)
                {
                    me.TeamCompeting = null;
                }
                else
                {
                    me.TeamCompeting = LookupTeamById(int.Parse(cols[1]));
                }
                me.Score = double.Parse(cols[2]);
                int parentId = 0;
                if(int.TryParse(cols[3],out parentId))
                {
                    me.ParentMatchup = LookupMatchupById(int.Parse(cols[3]));
                }
                else
                {
                    me.ParentMatchup = null;
                }
                output.Add(me);
            }
            return output;
        }

        private static List<MatchupEntryModel> ConvertStringToMatchupEntryModels(string input)
        {
            string[] ids = input.Split('|');
            List<MatchupEntryModel> output = new List<MatchupEntryModel> ();
            List<string> entries = GlobalConfig.MatchupEntryFile.FullFilePath().LoadFile();
            List<string> matchingEntries = new List<string>();
            foreach(string id in ids)
            {
                foreach(string entry in entries)
                {
                    string[] cols = entry.Split(',');
                    if (cols[0] == id)
                    {
                        matchingEntries.Add(entry);
                    }
                }
            }
            output = matchingEntries.ConvertToMatchupEntryModel();
            return output;
        }

        private static TeamModel LookupTeamById(int id)
        {
            List<string> teams = GlobalConfig.TeamFile.FullFilePath().LoadFile();
            foreach(string team in teams)
            {
                string[] cols = team.Split(',');
                if (cols[0] == id.ToString())
                {
                    List<string> matchingTeams = new List<string>();
                    matchingTeams.Add(team);
                    return matchingTeams.ConvertToTeamModels(GlobalConfig.PeopleFile).First();
                }
            }
            return null;
        }

        private static MatchupModel LookupMatchupById(int id)
        {
            List<string> matchups = GlobalConfig.MatchupFile.FullFilePath().LoadFile();
            foreach(string matchup in matchups)
            {
                string[] cols = matchup.Split(',');
                if (cols[0] == id.ToString())
                {
                    List<string> matchingMatchup  = new List<string>();
                    matchingMatchup.Add(matchup);
                    return matchingMatchup.ConvertToMatchupModel().First();
                }
            }
            return null;
        }

        public static List<MatchupModel> ConvertToMatchupModel(this List<string> lines)
        {
            List<MatchupModel> output = new List<MatchupModel>();
            foreach (string line in lines)
            {
                string[] cols = line.Split(',');
                MatchupModel p = new MatchupModel();
                p.Id = int.Parse(cols[0]);
                p.Entries = ConvertStringToMatchupEntryModels(cols[1]);
                if (cols[2].Length == 0)
                {
                    p.Winner = null;
                }
                else
                {
                    p.Winner = LookupTeamById(int.Parse(cols[2]));
                }
                p.MatchupRound = int.Parse(cols[3]);
                output.Add(p);
            }
            return output;
        }

        public static void SaveRoundToFile(this TournamentModel model, string MatchupFile, string MatchupEntryFile)
        {
            foreach (List<MatchupModel> round in model.Rounds)
            {
                foreach (MatchupModel matchup in round)
                {
                    matchup.SaveMatchupToFile(MatchupFile, MatchupEntryFile);
                }
            }
        }

        public static void SaveMatchupToFile(this MatchupModel matchup, string MatchupFile, string MatchupEntryFile)
        {
            List<MatchupModel> matchups = GlobalConfig.MatchupFile.FullFilePath().LoadFile().ConvertToMatchupModel();
            int currentId = 1;
            if (matchups.Count > 0)
            {
                currentId = matchups.OrderByDescending(x => x.Id).First().Id + 1;
            }
            matchup.Id = currentId;
            matchups.Add(matchup);

            foreach (MatchupEntryModel entry in matchup.Entries)
            {
                entry.SaveEntryToFile(MatchupEntryFile);
            }

            List<string> lines = new List<string>();
            foreach(MatchupModel m in matchups)
            {
                string winner = "";
                if(m.Winner != null) 
                {
                    winner = m.Winner.Id.ToString();
                }
                lines.Add($"{m.Id},{convertMatchupEntryListToString(m.Entries)},{winner},{m.MatchupRound}");
            }
            File.WriteAllLines(GlobalConfig.MatchupFile.FullFilePath(), lines);
        }

        public static void SaveEntryToFile(this MatchupEntryModel entry, string MatchupEntryFile)
        {
            List<MatchupEntryModel> entries = GlobalConfig.MatchupEntryFile.FullFilePath().LoadFile().ConvertToMatchupEntryModel();
            int currentId = 1;
            if(entries.Count > 0)
            {
                currentId = entries.OrderByDescending(x => x.Id).First().Id + 1;
            }
            entry.Id = currentId;
            entries.Add(entry);

            List<string> lines = new List<string>();
            foreach (MatchupEntryModel e in entries)
            {
                string parent = "";
                if(e.ParentMatchup != null)
                {
                    parent = e.ParentMatchup.Id.ToString();
                }
                string teamCompeting = "";
                if(e.TeamCompeting != null)
                {
                    teamCompeting = e.TeamCompeting.Id.ToString();
                }
                lines.Add($"{e.Id},{teamCompeting},{e.Score},{parent}");
            }
            File.WriteAllLines(GlobalConfig.MatchupEntryFile.FullFilePath(), lines);
        }

        public static void SaveToTournamentFile(this List<TournamentModel> models,string fileName)
        {
            List<string> lines = new List<string>();
            foreach(TournamentModel tm in models)
            {
                lines.Add($"{tm.Id},{tm.TournamentName},{tm.EntryFee},{convertTeamListToString(tm.EnteredTeams)},{convertPrizeListToString(tm.Prizes)},{convertRoundListToString(tm.Rounds)}");
                File.WriteAllLines(fileName.FullFilePath(), lines);
            }
        }
        private static string convertRoundListToString(List<List<MatchupModel>> rounds)
        {
            string output = "";
            if (rounds.Count == 0)
            {
                return "";
            }
            foreach (List<MatchupModel> r in rounds)
            {
                output += $"{convertMatchupListToString(r)}|";
            }
            output = output.Substring(0, output.Length - 1);
            return output;
        }

        private static string convertMatchupListToString(List<MatchupModel> matchups)
        {
            string output = "";
            if (matchups.Count == 0)
            {
                return "";
            }
            foreach (MatchupModel m in matchups)
            {
                output += $"{m.Id}^";
            }
            output = output.Substring(0, output.Length - 1);
            return output;
        }

        private static string convertTeamListToString(List<TeamModel> teams)
        {
            string output = "";
            if (teams.Count == 0)
            {
                return "";
            }
            foreach (TeamModel t in teams)
            {
                output += $"{t.Id}|";
            }
            output = output.Substring(0, output.Length - 1);
            return output;
        }
        private static string convertPrizeListToString(List<PrizeModel> prizes)
        {
            string output = "";
            if (prizes.Count == 0)
            {
                return "";
            }
            foreach (PrizeModel p in prizes)
            {
                output += $"{p.Id}|";
            }
            output = output.Substring(0, output.Length - 1);
            return output;
        }

        private static string convertMatchupEntryListToString(List<MatchupEntryModel> entries)
        {
            string output = "";
            if (entries.Count == 0)
            {
                return "";
            }
            foreach (MatchupEntryModel e in entries)
            {
                output += $"{e.Id}|";
            }
            output = output.Substring(0, output.Length - 1);
            return output;
        }

        private static string convertPeopleListToString(List<PersonModel> people)
        {
            string output = "";
            if(people.Count == 0)
            {
                return "";
            }
            foreach(PersonModel p in people)
            {
                output += $"{p.Id}|";
            }
            output = output.Substring(0, output.Length - 1);
            return output;
        }
    }
}