using System;
using System.Collections.Generic;

namespace Entities.Entities
{
    public partial class PayPeriodEmployeeUsedVacationsOnCallPayComissionsAttendanceOt
    {
        public PayPeriodEmployeeUsedVacationsOnCallPayComissionsAttendanceOt()
        {
            DeductionsPaySheets = new HashSet<DeductionsPaySheet>();
        }

        public int IdPaySheet { get; set; }
        public int? IdPayPeriod { get; set; }
        public int? IdEmployee { get; set; }
        public int? IdUsedVacactions { get; set; }
        public int? IdOncallPay { get; set; }
        public int? IdCommision { get; set; }
        public int? IdAttendance { get; set; }
        public decimal? TotalPay { get; set; }
        public decimal? OtherSalary { get; set; }
        public int? IdOverTime { get; set; }
        public decimal? ByweeklyGrossPay { get; set; }
        public decimal? NetPay { get; set; }
        public string? Description { get; set; }

        public virtual Attendance? IdAttendanceNavigation { get; set; }
        public virtual Commission? IdCommisionNavigation { get; set; }
        public virtual Employee? IdEmployeeNavigation { get; set; }
        public virtual OncallPay? IdOncallPayNavigation { get; set; }
        public virtual OverTime? IdOverTimeNavigation { get; set; }
        public virtual PayPeriod? IdPayPeriodNavigation { get; set; }
        public virtual UsedVacation? IdUsedVacactionsNavigation { get; set; }
        public virtual ICollection<DeductionsPaySheet> DeductionsPaySheets { get; set; }
    }
}
