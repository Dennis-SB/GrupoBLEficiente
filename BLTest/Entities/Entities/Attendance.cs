using System;
using System.Collections.Generic;

namespace Entities.Entities
{
    public partial class Attendance
    {
        public Attendance()
        {
            PayPeriodEmployeeUsedVacationsOnCallPayComissionsAttendanceOts = new HashSet<PayPeriodEmployeeUsedVacationsOnCallPayComissionsAttendanceOt>();
        }

        public int IdAttendance { get; set; }
        public int? IdEmployee { get; set; }
        public int? IdPayPeriod { get; set; }
        public int? WorkedDays { get; set; }
        public int? Absences { get; set; }
        public bool? AbsenceJustified { get; set; }
        public bool? AbsenceSubSidized { get; set; }
        public string? Description { get; set; }

        public virtual Employee? IdEmployeeNavigation { get; set; }
        public virtual PayPeriod? IdPayPeriodNavigation { get; set; }
        public virtual ICollection<PayPeriodEmployeeUsedVacationsOnCallPayComissionsAttendanceOt> PayPeriodEmployeeUsedVacationsOnCallPayComissionsAttendanceOts { get; set; }
    }
}
