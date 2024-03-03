using System;
using System.Collections.Generic;

namespace Entities.Entities
{
    public partial class DeductionType
    {
        public DeductionType()
        {
            Deductions = new HashSet<Deduction>();
        }

        public int IdDeductionType { get; set; }
        public string? Name { get; set; }
        public string? Description { get; set; }

        public virtual ICollection<Deduction> Deductions { get; set; }
    }
}
