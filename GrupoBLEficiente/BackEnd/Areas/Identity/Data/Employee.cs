using BackEnd.Areas.Identity.Data;
using System;
using System.Collections.Generic;

namespace Entities.Entities
{
    public partial class Employee
    {
        public Employee()
        {
            GrupoBLUsers = new HashSet<GrupoBLUser>();
        }

        public int IdEmployee { get; set; }
        public string? Name { get; set; }
        public string? LastName { get; set; }
        public int? IdType { get; set; }
        public string? NationalId { get; set; }
        public DateTime? BirthDate { get; set; }
        public DateTime? HireDate { get; set; }
        public string? Email { get; set; }
        public string? Phone { get; set; }
        public string? Address { get; set; }
        public int? IdJobTitle { get; set; }
        public decimal? MonthlyGrossSalary { get; set; }
        public string? Status { get; set; }

        public virtual JobTitle? IdJobTitleNavigation { get; set; }
        public virtual NationalIdType? IdTypeNavigation { get; set; }
        public virtual ICollection<GrupoBLUser> GrupoBLUsers { get; set; }
    }
}
