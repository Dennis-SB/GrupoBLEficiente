using System;
using System.Collections.Generic;

namespace Entities.Entities
{
    public partial class EventsLog
    {
        public int IdEvent { get; set; }
        public string? Name { get; set; }
        public string? EventType { get; set; }
        public DateTime? EventDate { get; set; }
        public TimeSpan? EventTime { get; set; }
        public int? IdUser { get; set; }
        public string? Description { get; set; }

        public virtual User? IdUserNavigation { get; set; }
    }
}
