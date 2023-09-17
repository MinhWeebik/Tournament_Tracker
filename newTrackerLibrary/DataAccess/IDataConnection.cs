using newTrackerLibrary.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace newTrackerLibrary.DataAccess
{
    public interface IDataConnection
    {
        void createPrize(PrizeModel model);
        void createPerson(PersonModel model);
        void createTeam(TeamModel model);
        void createTournament(TournamentModel model);
        void updateMatchup(MatchupModel model);
        List<TeamModel> getTeam_All();
        List<PersonModel> getPerson_All();
        List<TournamentModel> getTournament_All();
    }
}
