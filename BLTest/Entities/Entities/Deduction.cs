using System;
using System.Collections.Generic;

namespace Entities.Entities
{
    public partial class Deduction
    {
        public Deduction()
        {
            DeductionsPaySheets = new HashSet<DeductionsPaySheet>();
        }

        public int IdDeduction { get; set; }
        public int? IdDeductionType { get; set; }
        public decimal? StartRange { get; set; }
        public decimal? EndRange { get; set; }
        public decimal? DeductionPercentage { get; set; }
        public string? Description { get; set; }

        public virtual DeductionType? IdDeductionTypeNavigation { get; set; }
        public virtual ICollection<DeductionsPaySheet> DeductionsPaySheets { get; set; }
    }
}
