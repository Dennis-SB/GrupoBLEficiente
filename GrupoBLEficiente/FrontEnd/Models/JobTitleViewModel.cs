using System.ComponentModel.DataAnnotations;

namespace FrontEnd.Models
{
    public class JobTitleViewModel
    {
        [Key]
        public int IdJobTitle { get; set; }

        [Required(ErrorMessage = "El titulo de trabajo es requerido")]
        [Display(Name = "Titulo de Trabajo")]
        public string? Name { get; set; }

        [Display(Name = "Descripción")]
        public string? Description { get; set; }
    }
}