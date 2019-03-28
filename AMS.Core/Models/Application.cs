using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AMS.Core.Models
{
    public class Application : Entity
    {
        public virtual Applicant Applicant { get; set; }
        public virtual List<Specialty> Specialties { get; set; }
    }
}
