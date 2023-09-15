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
        PrizeModel createPrize(PrizeModel model);
        PersonModel createPerson(PersonModel model);
        TeamModel createTeam(TeamModel model);
        void createTournament(TournamentModel model);
        List<TeamModel> getTeam_All();
        List<PersonModel> getPerson_All();

        List<TournamentModel> getTournament_All();
    }
}
