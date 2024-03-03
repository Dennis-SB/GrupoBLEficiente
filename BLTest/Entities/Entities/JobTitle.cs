using System;
using System.Collections.Generic;

namespace Entities.Entities
{
    public partial class JobTitle
    {
        public JobTitle()
        {
            Employees = new HashSet<Employee>();
        }

        public int IdJobTitle { get; set; }
        public string? Name { get; set; }
        public string? Description { get; set; }

        public virtual ICollection<Employee> Employees { get; set; }
    }
}
