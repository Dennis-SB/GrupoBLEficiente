using System;
using System.Collections.Generic;

namespace Entities.Entities
{
    public partial class Employee
    {
        public Employee()
        {
            AccruedVacations = new HashSet<AccruedVacation>();
            Attendances = new HashSet<Attendance>();
            Commissions = new HashSet<Commission>();
            OncallPays = new HashSet<OncallPay>();
            OverTimes = new HashSet<OverTime>();
            PayPeriodEmployeeUsedVacationsOnCallPayComissionsAttendanceOts = new HashSet<PayPeriodEmployeeUsedVacationsOnCallPayComissionsAttendanceOt>();
            UsedVacations = new HashSet<UsedVacation>();
            Users = new HashSet<User>();
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
        public decimal? MonthlyGrossSalary { get; set; }
        public int? IdJobTitle { get; set; }
        public string? Status { get; set; }

        public virtual JobTitle? IdJobTitleNavigation { get; set; }
        public virtual NationalIdType? IdTypeNavigation { get; set; }
        public virtual ICollection<AccruedVacation> AccruedVacations { get; set; }
        public virtual ICollection<Attendance> Attendances { get; set; }
        public virtual ICollection<Commission> Commissions { get; set; }
        public virtual ICollection<OncallPay> OncallPays { get; set; }
        public virtual ICollection<OverTime> OverTimes { get; set; }
        public virtual ICollection<PayPeriodEmployeeUsedVacationsOnCallPayComissionsAttendanceOt> PayPeriodEmployeeUsedVacationsOnCallPayComissionsAttendanceOts { get; set; }
        public virtual ICollection<UsedVacation> UsedVacations { get; set; }
        public virtual ICollection<User> Users { get; set; }
    }
}
