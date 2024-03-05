namespace FrontEnd.Models
{
    public class EmployeeViewModel
    {
        public int IdEmployee { get; set; }
        public string? Name { get; set; }
        public string? LastName { get; set; }
        public int? IdType { get; set; }
        public IEnumerable<NationalIdTypeViewModel> NationalIdTypes { get; set; }
        public string? NationalId { get; set; }
        public DateTime? BirthDate { get; set; }
        public DateTime? HireDate { get; set; }
        public string? Email { get; set; }
        public string? Phone { get; set; }
        public string? Address { get; set; }
        public int? IdJobTitle { get; set; }
        public IEnumerable<JobTitleViewModel> JobTitles { get; set; }
        public decimal? MonthlyGrossSalary { get; set; }
        public string? Status { get; set; }
    }
}