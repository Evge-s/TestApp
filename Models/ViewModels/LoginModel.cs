using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace TestApp.Models.ViewModels
{
    public class LoginModel
    {
        [Required(ErrorMessage = "Invalid login!")]
        public string Login { get; set; }

        [Required(ErrorMessage = "Invalid password!")]
        [PasswordPropertyText]
        [DataType(DataType.Password)]
        public string Password { get; set; }
    }
}
