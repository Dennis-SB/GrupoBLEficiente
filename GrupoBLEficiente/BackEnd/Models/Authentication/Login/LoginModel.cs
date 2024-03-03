using System.ComponentModel.DataAnnotations;

namespace BackEnd.Models.Authentication.Login
{
    public class LoginModel
    {
        [Required(ErrorMessage = "User Name is required")]
        public string? Username { get; set; }

        [Required(ErrorMessage = "Password is required")]
        public string? Password { get; set; }

        public List<string>? Roles { get; set; }
    }
}