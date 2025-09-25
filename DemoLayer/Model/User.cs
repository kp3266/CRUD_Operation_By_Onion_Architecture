using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoLayer.Model
{
    public class User
    {
        /// <summary>
        /// Gets or sets the user identifier.
        /// </summary>
        [Key]
        public long userId { get; set; }

        /// <summary>
        /// Gets or sets the user name.
        /// </summary>
        public string userName { get; set; }

        /// <summary>
        /// Gets or sets the user phone number.
        /// </summary>
        public string userPhoneNumber { get; set; }

        /// <summary>
        /// Gets or sets the user email.
        /// </summary>
        public string userEmail { get; set; }

        /// <summary>
        /// Gets or sets the user address.
        /// </summary>
        public string userAddress { get; set; }

        /// <summary>
        /// Gets or sets the created date and time of the user.
        /// </summary>
        public DateTime createdDateTime { get; set; }

        /// <summary>
        /// Gets or sets the updated date and time of the user.
        /// </summary>
        public DateTime updatedDateTime { get; set; }


    }
}
