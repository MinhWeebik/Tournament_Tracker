using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Permissions;
using System.Text;
using System.Threading.Tasks;

namespace newTrackerLibrary.Models
{
    public class MatchupModel
    {
        public int Id { get; set; }
        /// <summary>
        /// Tượng trưng cho danh sách những đội tham gia trận đấu.
        /// </summary>
        public List<MatchupEntryModel> Entries { get; set; } = new List<MatchupEntryModel>();
        /// <summary>
        /// ID từ cơ sở dữ liệu dùng để định danh người thắng.
        /// </summary>
        public int WinnerId { get; set; }
        /// <summary>
        /// Tượng trưng cho đội thắng trận đấu này.
        /// </summary>
        public TeamModel Winner { get; set; }
        /// <summary>
        /// Tượng trưng cho vòng mà trận đấu này lằm trong.
        /// </summary>
        public int MatchupRound { get; set; }

        public string DisplayName
        {
            get
            {
                string output = "";
                foreach (MatchupEntryModel me in Entries)
                {
                    if (me.TeamCompeting != null)
                    {
                        if (output.Length == 0)
                        {
                            output = me.TeamCompeting.TeamName;
                        }
                        else
                        {
                            output += $" vs. {me.TeamCompeting.TeamName}";
                        } 
                    }
                    else
                    {
                        output = "Các trận đấu chưa quyết định";
                        break;
                    }
                }
                return output;
            }
        }
    }
}
