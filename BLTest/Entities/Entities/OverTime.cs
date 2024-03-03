using System;
using System.Collections.Generic;

namespace Entities.Entities
{
    public partial class OverTime
    {
        public OverTime()
        {
            PayPeriodEmployeeUsedVacationsOnCallPayComissionsAttendanceOts = new HashSet<PayPeriodEmployeeUsedVacationsOnCallPayComissionsAttendanceOt>();
        }

        public int IdOverTime { get; set; }
        public int? IdEmployee { get; set; }
        public decimal? Othours { get; set; }
        public string? Description { get; set; }
        public int? IdPayPeriod { get; set; }

        public virtual Employee? IdEmployeeNavigation { get; set; }
        public virtual PayPeriod? IdPayPeriodNavigation { get; set; }
        public virtual ICollection<PayPeriodEmployeeUsedVacationsOnCallPayComissionsAttendanceOt> PayPeriodEmployeeUsedVacationsOnCallPayComissionsAttendanceOts { get; set; }
    }
}
