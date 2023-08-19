using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrackerLibrary
{
    public class MatchupModel
    {
        /// <summary>
        /// Tượng trưng cho danh sách những đội tham gia trận đấu.
        /// </summary>
        public List<MatchupEntryModel> Entries { get; set; } = new List<MatchupEntryModel>();
        /// <summary>
        /// Tượng trưng cho đội thắng trận đấu này.
        /// </summary>
        public TeamModel Winner { get; set; }
        /// <summary>
        /// Tượng trưng cho vòng mà trận đấu này lằm trong.
        /// </summary>
        public int MatchupRound { get; set; }
    }
}
