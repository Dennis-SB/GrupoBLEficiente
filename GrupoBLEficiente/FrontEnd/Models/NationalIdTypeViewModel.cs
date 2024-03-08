using System.ComponentModel.DataAnnotations;

namespace FrontEnd.Models
{
    public class NationalIdTypeViewModel
    {
        [Key]
        public int IdType { get; set; }

        [Required(ErrorMessage = "El tipo de documento de identificación es requerido")]
        [Display(Name = "Tipo de Documento de Identificación")]
        public string? Name { get; set; }

        [Display(Name = "Descripción")]
        public string? Description { get; set; }
    }
}