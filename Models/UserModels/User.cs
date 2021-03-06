using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace TestApp.Models.UserModels
{
    public class User
    {
        public int Id { get; set; }
        [Required]
        public string Login { get; set; }

        [PasswordPropertyText]
        public string Password { get; set; }
    }
}
