using System;
using System.Collections.Generic;

namespace Entities.Entities
{
    public partial class DeductionsPaySheet
    {
        public int IdDeductionsPaySheet { get; set; }
        public int? IdDeduction { get; set; }
        public int? IdPaySheet { get; set; }
        public string? Description { get; set; }

        public virtual Deduction? IdDeductionNavigation { get; set; }
        public virtual PayPeriodEmployeeUsedVacationsOnCallPayComissionsAttendanceOt? IdPaySheetNavigation { get; set; }
    }
}
