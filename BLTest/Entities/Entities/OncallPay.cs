using System;
using System.Collections.Generic;

namespace Entities.Entities
{
    public partial class OncallPay
    {
        public OncallPay()
        {
            PayPeriodEmployeeUsedVacationsOnCallPayComissionsAttendanceOts = new HashSet<PayPeriodEmployeeUsedVacationsOnCallPayComissionsAttendanceOt>();
        }

        public int IdOncallPay { get; set; }
        public int? IdEmployee { get; set; }
        public int? IdPayPeriod { get; set; }
        public decimal? OncallPaySum { get; set; }
        public string? Description { get; set; }

        public virtual Employee? IdEmployeeNavigation { get; set; }
        public virtual PayPeriod? IdPayPeriodNavigation { get; set; }
        public virtual ICollection<PayPeriodEmployeeUsedVacationsOnCallPayComissionsAttendanceOt> PayPeriodEmployeeUsedVacationsOnCallPayComissionsAttendanceOts { get; set; }
    }
}
