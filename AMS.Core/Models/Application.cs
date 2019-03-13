using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AMS.Core.Models
{
    public class Application : Entity
    {
        public Dictionary<University, string> Specialties { get; set; }
        public virtual Applicant Applicant { get; set; }
    }
}
