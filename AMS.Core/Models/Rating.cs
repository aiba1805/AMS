using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AMS.Core.Models
{
    public class Rating : Entity
    {
        public double Overall { get; set; }
        public double Teaching { get; set; }
        public double Employeer { get; set; }
        public double Academing { get; set; }
    }
}
