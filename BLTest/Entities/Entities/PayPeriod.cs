using System;
using System.Collections.Generic;

namespace Entities.Entities
{
    public partial class PayPeriod
    {
        public PayPeriod()
        {
            Attendances = new HashSet<Attendance>();
            Commissions = new HashSet<Commission>();
            OncallPays = new HashSet<OncallPay>();
            OverTimes = new HashSet<OverTime>();
            PayPeriodEmployeeUsedVacationsOnCallPayComissionsAttendanceOts = new HashSet<PayPeriodEmployeeUsedVacationsOnCallPayComissionsAttendanceOt>();
            UsedVacations = new HashSet<UsedVacation>();
        }

        public int IdPayPeriod { get; set; }
        public string? Name { get; set; }
        public DateTime? PeriodStart { get; set; }
        public DateTime? PeriodEnd { get; set; }
        public string? Description { get; set; }

        public virtual ICollection<Attendance> Attendances { get; set; }
        public virtual ICollection<Commission> Commissions { get; set; }
        public virtual ICollection<OncallPay> OncallPays { get; set; }
        public virtual ICollection<OverTime> OverTimes { get; set; }
        public virtual ICollection<PayPeriodEmployeeUsedVacationsOnCallPayComissionsAttendanceOt> PayPeriodEmployeeUsedVacationsOnCallPayComissionsAttendanceOts { get; set; }
        public virtual ICollection<UsedVacation> UsedVacations { get; set; }
    }
}
