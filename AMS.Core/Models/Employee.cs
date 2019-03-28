using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AMS.Core.Models
{
    public class Employee : Entity
    {
        public string Position { get; set; }
        public virtual User User{
            get;
            set;
        }
    }
}
