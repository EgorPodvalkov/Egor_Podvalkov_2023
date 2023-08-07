using System.ComponentModel.DataAnnotations;

namespace Task1.Models
{
    public class UserValidationModel
    {
        [Required(ErrorMessage = "Name can not be empty!")]
        public string UserName { get; set; }

        [Required(ErrorMessage = "Password can not be empty!")]
        public string Password { get; set; }

        public string Message { get; set; } = "";
    }
}
