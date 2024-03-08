using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text.Json.Serialization;

namespace FrontEnd.Models
{
    public class EmployeeViewModel
    {
        [Key]
        public int IdEmployee { get; set; }

        [Required(ErrorMessage = "El nombre es requerido")]
        [Display(Name = "Nombre")]
        public string? Name { get; set; }

        [Required(ErrorMessage = "Los apellidos son requeridos")]
        [Display(Name = "Apellidos")]
        public string? LastName { get; set; }

        [Required(ErrorMessage = "El de tipo de documento es requerido")]
        [Display(Name = "Tipo de Documento de Identificación")]
        public int? IdType { get; set; }

        [JsonIgnore]
        public IEnumerable<NationalIdTypeViewModel> NationalIdTypes { get; set; }

        [Required(ErrorMessage = "El número de documento es requerido")]
        [Display(Name = "Número de Identificación")]
        public string? NationalId { get; set; }

        [Required(ErrorMessage = "La fecha es requerida")]
        [Display(Name = "Fecha de Nacimiento")]
        [DataType(DataType.Date)]
        [DisplayFormat(ApplyFormatInEditMode = true, DataFormatString = "{0:dd-MM-yyyy}")]
        public DateTime? BirthDate { get; set; }

        [Required(ErrorMessage = "La fecha de inicio es requerida")]
        [Display(Name = "Fecha de Inicio")]
        [DataType(DataType.Date)]
        [DisplayFormat(ApplyFormatInEditMode = true, DataFormatString = "{0:dd-MM-yyyy}")]
        public DateTime? HireDate { get; set; }

        [Required(ErrorMessage = "El correo electrónico requerido")]
        [EmailAddress(ErrorMessage = "Utilice el formato de correo electrónico")]
        [Display(Name = "Correo Electrónico")]
        public string? Email { get; set; }

        [Required(ErrorMessage = "El número teléfonico es requerido")]
        [Display(Name = "Número Teléfonico")]
        public string? Phone { get; set; }

        [Required(ErrorMessage = "La dirección es requerida")]
        [Display(Name = "Dirección Física")]
        public string? Address { get; set; }

        [Required(ErrorMessage = "El titulo de trabajo es requerido")]
        [Display(Name = "Titulo de Trabajo")]
        public int? IdJobTitle { get; set; }

        [JsonIgnore]
        public IEnumerable<JobTitleViewModel> JobTitles { get; set; }

        [DataType(DataType.Currency)]
        [Column(TypeName = "decimal(18, 2)")]
        public decimal? MonthlyGrossSalary { get; set; }

        [Required(ErrorMessage = "El estado es requerido")]
        [Display(Name = "Estado")]
        public string? Status { get; set; }
    }
}