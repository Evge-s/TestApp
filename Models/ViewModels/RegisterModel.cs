using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace TestApp.Models.ViewModels
{
    public class RegisterModel
    {
        [Required(ErrorMessage = "No login is assigned!")]
        public string Login { get; set; }

        [StringLength(12, MinimumLength = 6, ErrorMessage = "Password length must be 6 or more characters")]
        [PasswordPropertyText]
        [DataType(DataType.Password)]
        public string Password { get; set; }

        [Compare("Password", ErrorMessage = "Passwords don't match!")]
        [PasswordPropertyText]
        [DataType(DataType.Password)]
        public string ConfirmPassword { get; set; }
    }
}
