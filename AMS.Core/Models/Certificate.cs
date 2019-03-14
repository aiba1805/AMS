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
    public class Certificate : Entity
    {
        public CertificateType CertificateType { get; set; }
        public string CertificateFile { get; set; }
    }
}
