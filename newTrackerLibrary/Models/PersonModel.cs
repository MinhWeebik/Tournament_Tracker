using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace newTrackerLibrary.Models
{
    public class PersonModel
    {
        /// <summary>
        /// Tượng trưng cho tên đầu.
        /// </summary>
        public string FirstName { get; set; }
        /// <summary>
        /// Tượng trưng cho tên họ.
        /// </summary>
        public string LastName { get; set; }
        /// <summary>
        /// Tượng trưng cho địa chỉ Email.
        /// </summary>
        public string EmailAddress { get; set; }
        /// <summary>
        /// Tượng trưng cho số điện thoại.
        /// </summary>
        public string CellphoneNumber { get; set; }
    }
}
