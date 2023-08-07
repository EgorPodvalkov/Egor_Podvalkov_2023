using System.ComponentModel.DataAnnotations;

namespace Task1.Models
{
    public class UserModel
    {
        /// <summary>
        /// User`s ID
        /// </summary>
        public int UserID { get; set; }

        /// <summary>
        /// User`s name
        /// </summary>
        public string UserName { get; set; }
        
        /// <summary>
        /// User`s password
        /// </summary>
        public string Password { get; set; }

        /// <summary>
        /// True, if user is admin, otherwise false
        /// </summary>
        public bool IsAdmin { get; set; }
    }
}
