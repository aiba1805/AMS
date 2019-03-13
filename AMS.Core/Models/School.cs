using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AMS.Core.Models
{
    public class School : Entity
    {
        public string Name { get; set; }
        public virtual Location Location {get;set;}
        public bool Village { get; set; }
    }
}
