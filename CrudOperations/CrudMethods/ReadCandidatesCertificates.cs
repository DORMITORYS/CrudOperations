using CrudOperations.ApplicationDbContext;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tables.Models;

namespace CrudOperations.CrudMethods
{
    public class ReadCandidatesCertificates
    {
        public ReadCandidatesCertificates()
        {
            Console.Write("Enter your id: ");
            int id = int.Parse(Console.ReadLine());
            AppDbContext appDbContext = new AppDbContext();
            var yourCertificates = (from Result in appDbContext.Results
                                    where Result.Candidates.CandidateID == id
                                    select Result).ToList<Result>();

            foreach (var certificate in yourCertificates)
            {
                Console.WriteLine(certificate.ToString());
            }
            appDbContext.Dispose();
        }
    }
}
