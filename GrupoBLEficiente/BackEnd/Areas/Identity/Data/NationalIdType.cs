using System;
using System.Collections.Generic;

namespace Entities.Entities
{
    public partial class NationalIdType
    {
        public NationalIdType()
        {
            Employees = new HashSet<Employee>();
        }

        public int IdType { get; set; }
        public string? Name { get; set; }
        public string? Description { get; set; }

        public virtual ICollection<Employee> Employees { get; set; }
    }
}
