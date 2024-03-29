﻿using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace BackEnd.Models.Authentication.SignUp
{
    public class RegisterUser
    {
        [Display(Name = "Nombre de Usuario")]
        [Required(ErrorMessage = "El Nombre de Usuario es requerido")]
        public string? Username { get; set; }

        [Display(Name = "Contraseña")]
        [Required(ErrorMessage = "La Contraseña es requerida")]
        [PasswordPropertyText]
        public string? Password { get; set; }

        [Display(Name = "Correo Electronico")]
        [EmailAddress]
        [Required(ErrorMessage = "El correo es requerido")]
        public string? Email { get; set; }
    }
}