using System;
using System.Collections.Generic;

namespace Entities.Entities
{
    public partial class AccruedVacation
    {
        public int IdAccruedVacation { get; set; }
        public int? IdEmployee { get; set; }
        public decimal? AccruedVacation1 { get; set; }
        public string? Description { get; set; }

        public virtual Employee? IdEmployeeNavigation { get; set; }
    }
}
