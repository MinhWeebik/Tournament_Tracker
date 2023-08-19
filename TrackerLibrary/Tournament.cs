using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrackerLibrary
{
    public class Tournament
    {
        /// <summary>
        /// Tượng trưng cho tên giải đấu.
        /// </summary>
        public string TournamentName { get; set; }
        /// <summary>
        /// Tượng trưng cho phí tham gia.
        /// </summary>
        public decimal EntryFee { get; set; }
        /// <summary>
        /// Tượng trưng cho danh sách những đội tham gia trong giải đấu.
        /// </summary>
        public List<TeamModel> EnteredTeams { get; set; } = new List<TeamModel>();
        /// <summary>
        /// Tượng trưng cho danh sách giải thưởng.
        /// </summary>
        public List<PrizeModel> Prizes { get; set; } = new List<PrizeModel>();
        /// <summary>
        /// Tượng trưng cho danh sách các vòng của trận đấu.
        /// </summary>
        public List<List<MatchupModel>> Rounds { get; set; } = new List<List<MatchupModel>>();
    }
}
