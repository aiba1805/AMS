﻿using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AMS.Core.Models
{
    public class Applicant : Entity
    {
        public string IIN { get; set; }
        
        public string Residence { get; set; }
        public string MilitaryDocument { get; set; }
        public virtual Certificate Certificate { get; set; }
        public virtual School School { get; set; }
        public virtual UNT UNT { get; set; }

        public virtual User User{
            get;
            set;
        }
        public List<string> Diplomas { get; set; }

        public Applicant()
        {
            Diplomas = new List<string>();
        }
     }
}
