using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace BackEnd.Models.Authentication.SignUp
{
    public class RegisterUser
    {
        [Display(Name = "Número de Socio")]
        [Required(ErrorMessage = "El número de socio es requerido")]
        public string? Username { get; set; }

        [Display(Name = "Contraseña")]
        [Required(ErrorMessage = "Password is Required")]
        [PasswordPropertyText]
        public string? Password { get; set; }

        [Display(Name = "Correo Electronico")]
        [EmailAddress]
        [Required(ErrorMessage = "El correo es obligatorio")]
        public string? Email { get; set; }
    }
}