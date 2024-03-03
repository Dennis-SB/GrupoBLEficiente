using System;
using System.Collections.Generic;

namespace Entities.Entities
{
    public partial class User
    {
        public User()
        {
            ErrorsLogs = new HashSet<ErrorsLog>();
            EventsLogs = new HashSet<EventsLog>();
        }

        public int IdUser { get; set; }
        public string? UserName { get; set; }
        public string? Password { get; set; }
        public int? IdRol { get; set; }
        public int? IdEmployee { get; set; }

        public virtual Employee? IdEmployeeNavigation { get; set; }
        public virtual Role? IdRolNavigation { get; set; }
        public virtual ICollection<ErrorsLog> ErrorsLogs { get; set; }
        public virtual ICollection<EventsLog> EventsLogs { get; set; }
    }
}
