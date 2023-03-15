using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tables.Models
{
    public class Certificate
    {
        public int CertificateId { get; set; }
        public string AllCertificates { get; set; }

        public Certificate() { }

        public Certificate(int certificateId, string AllCertificates)
        {
            CertificateId = certificateId;
            this.AllCertificates = AllCertificates;
        }

        public Certificate(string AllCertificates)
        {
            this.AllCertificates = AllCertificates;
        }
    }
}
