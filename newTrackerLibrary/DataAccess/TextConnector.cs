using newTrackerLibrary.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using newTrackerLibrary.DataAccess.TextHelper;

namespace newTrackerLibrary.DataAccess
{
    public class TextConnector : IDataConnection
    {
        public void completeTouranment(TournamentModel model)
        {
            List<TournamentModel> tournaments = GlobalConfig.TournamentFile.FullFilePath().LoadFile().ConvertToTournamentModels();
            for(int i=0;i<tournaments.Count;i++)
            {
                if (tournaments[i].Id == model.Id)
                {
                    tournaments.RemoveAt(i);
                }
            }
            tournaments.SaveToTournamentFile();
            TournamentLogic.UpdateTournamentResult(model);
        }

        public void createPerson(PersonModel model)
        {
            List<PersonModel> people = GlobalConfig.PeopleFile.FullFilePath().LoadFile().ConvertToPersonModels();
            int currentId = 1;
            if(people.Count > 0)
            {
                currentId = people.OrderByDescending(x => x.Id).First().Id + 1;
            }
            model.Id = currentId;
            people.Add(model);

            people.SaveToPeopleFile();
        }

        public void createPrize(PrizeModel model)
        {
            // Load file text và chuyển file text thành một danh sách PrizeModel
            List<PrizeModel> prizes = GlobalConfig.PrizesFile.FullFilePath().LoadFile().ConvertToPrizeModels();

            // Tìm id lớn nhất rồi + 1
            int currentId = 1;
            if(prizes.Count > 0)
            {
                currentId = prizes.OrderByDescending(x => x.Id).First().Id + 1;
            }
            model.Id = currentId;
            prizes.Add(model);

            // Chuyển model về dạng string rồi lưu vào file
            prizes.SaveToPrizeFile();
        }

        public void createTeam(TeamModel model)
        {
            List<TeamModel> teams = GlobalConfig.TeamFile.FullFilePath().LoadFile().ConvertToTeamModels();
            int currentId = 1;
            if (teams.Count > 0)
            {
                currentId = teams.OrderByDescending(x => x.Id).First().Id + 1;
            }
            model.Id = currentId;
            teams.Add(model);
            teams.SaveToTeamFile();
        }

        public void createTournament(TournamentModel model)
        {
            List<TournamentModel> tournaments = GlobalConfig.TournamentFile.FullFilePath().LoadFile().ConvertToTournamentModels();
            int currentId = 1;
            if (tournaments.Count > 0)
            {
                currentId = tournaments.OrderByDescending(x => x.Id).First().Id + 1;
            }
            model.Id = currentId;
            model.SaveRoundToFile();
            tournaments.Add(model);
            tournaments.SaveToTournamentFile();
            TournamentLogic.UpdateTournamentResult(model);
        }

        public List<PersonModel> getPerson_All()
        {
            return GlobalConfig.PeopleFile.FullFilePath().LoadFile().ConvertToPersonModels();
        }

        public List<TeamModel> getTeam_All()
        {
            List<TeamModel> output = GlobalConfig.TeamFile.FullFilePath().LoadFile().ConvertToTeamModels();
            return output;
        }

        public List<TournamentModel> getTournament_All()
        {
            return GlobalConfig.TournamentFile.FullFilePath().LoadFile().ConvertToTournamentModels();
        }

        public void updateMatchup(MatchupModel model)
        {
            model.UpdateMatchupToFile();
        }
    }
}
