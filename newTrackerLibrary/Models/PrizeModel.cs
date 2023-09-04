using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace newTrackerLibrary.Models
{
    public class PrizeModel
    {
        /// <summary>
        /// Mã của một phần thưởng
        /// </summary>
        public int Id { get; set; }
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
        public PrizeModel()
        {
            
        }
        public PrizeModel(string placeName,string placeNumber, string prizeAmount, string prizePercentage)
        {
            PlaceName = placeName;
            int placeNumberValue = 0;
            int.TryParse(placeNumber, out placeNumberValue);
            PlaceNumber = placeNumberValue;
            decimal prizeAmountValue = 0;
            decimal.TryParse(prizeAmount, out prizeAmountValue);
            PrizeAmount = prizeAmountValue;
            double prizePercentageValue = 0;
            double.TryParse(prizePercentage, out prizePercentageValue);
            PrizePercentage = prizePercentageValue;
        }
    }
}
