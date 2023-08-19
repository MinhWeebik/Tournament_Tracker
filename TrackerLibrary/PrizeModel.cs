using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrackerLibrary
{
    public class PrizeModel
    {
        /// <summary>
        /// Tượng trưng cho số thứ tự của giải thưởng.
        /// </summary>
        public int PlaceNumber { get; set; }
        /// <summary>
        /// Tượng trưng cho tên của thứ tự giải thưởng.
        /// </summary>
        public string PlaceName { get; set; }
        /// <summary>
        /// Tượng trưng cho số lượng giải thưởng.
        /// </summary>
        public decimal PrizeAmount { get; set; }
        /// <summary>
        /// Tượng trưng cho phần trăm giải thưởng.
        /// </summary>
        public double PrizePercentage { get; set; }
    }
}
