using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AMS.Core.Models
{
    public class University : Entity
    {
        public string Name { get; set; }
        public virtual List<Employee> Employees { get; set; }
        public virtual Rating Rating { get; set; }
        public virtual Location Location { get; set; }
    }
}
