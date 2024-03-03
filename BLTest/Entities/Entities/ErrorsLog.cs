using System;
using System.Collections.Generic;

namespace Entities.Entities
{
    public partial class ErrorsLog
    {
        public int IdError { get; set; }
        public string? ErrorMessage { get; set; }
        public DateTime? ErrorDate { get; set; }
        public TimeSpan? ErrorTime { get; set; }
        public int? IdUser { get; set; }
        public string? Description { get; set; }

        public virtual User? IdUserNavigation { get; set; }
    }
}
