using System;
using System.Collections.Generic;

namespace Entities.Entities
{
    public partial class UsedVacation
    {
        public UsedVacation()
        {
            PayPeriodEmployeeUsedVacationsOnCallPayComissionsAttendanceOts = new HashSet<PayPeriodEmployeeUsedVacationsOnCallPayComissionsAttendanceOt>();
        }

        public int IdUsedVacation { get; set; }
        public int? IdPayPeriod { get; set; }
        public int? IdEmployee { get; set; }
        public int? UsedDays { get; set; }
        public DateTime? StartDate { get; set; }
        public DateTime? EndDate { get; set; }
        public decimal? VacationsPay { get; set; }
        public string? Description { get; set; }

        public virtual Employee? IdEmployeeNavigation { get; set; }
        public virtual PayPeriod? IdPayPeriodNavigation { get; set; }
        public virtual ICollection<PayPeriodEmployeeUsedVacationsOnCallPayComissionsAttendanceOt> PayPeriodEmployeeUsedVacationsOnCallPayComissionsAttendanceOts { get; set; }
    }
}
