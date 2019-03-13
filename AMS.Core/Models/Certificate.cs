using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AMS.Core.Models
{
    public enum CertificateType
    {
        Red,Blue,Altyn
    }
    public class Certificate
    {
        public Dictionary<string,string> Marks { get; set; }
        public CertificateType CertificateType { get; set; }
        public IFormFile CertificateFile { get; set; }
    }
}
