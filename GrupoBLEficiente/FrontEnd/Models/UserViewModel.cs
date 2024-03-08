using System.ComponentModel.DataAnnotations;

namespace FrontEnd.Models
{
    public class UserViewModel
    {
        [Required(ErrorMessage = "El Nombre de Usuario es requerido")]
        [Display(Name = "Ingrese el Nombre de Usuario")]
        public string UserName { get; set; }
        public string? Email { get; set; }
        [Required(ErrorMessage = "La Contraseña es requerida")]

        [Display(Name = "Ingrese la Contraseña")]
        [DataType(DataType.Password)]
        public string Password { get; set; }
        
        public bool RememberLogin { get; set; }
        public string ReturnUrl { get; set; }
    }
}