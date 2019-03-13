using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AMS.Core.Models
{
    public class UNT:Entity
    {
        public int Points { get; set; }
        public string PlaceOfExam { get; set; }
        public virtual Application Application { get; set; }
    }
}
