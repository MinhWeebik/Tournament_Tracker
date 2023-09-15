using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace newTrackerLibrary.Models
{
    public class MatchupEntryModel
    {
        public int Id { get; set; }
        /// <summary>
        /// ID từ cơ sở dữ liệu dùng để định danh đội tham gia.
        /// </summary>
        public int TeamCompetingId { get; set; }
        /// <summary>
        /// Tượng trưng cho một đội trong trận đấu.
        /// </summary>
        public TeamModel TeamCompeting { get; set; }
        /// <summary>
        /// Tượng trưng cho tỉ số của đội này.
        /// </summary>
        public double Score { get; set; }
        /// <summary>
        /// ID từ cơ sở dữ liệu dùng để định danh trận đấu đội này đến từ.
        /// </summary>
        public int ParentMatchupId { get; set; }
        /// <summary>
        /// Tượng trưng cho trận đấu đội này đến từ với tư cách là người thắng.
        /// </summary>
        public MatchupModel ParentMatchup { get; set; }
    }
}
