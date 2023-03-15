using CrudOperations.ApplicationDbContext;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CrudOperations.CrudMethods
{
    public class ReadCandidates
    {
        public ReadCandidates()
        {
            AppDbContext appDbContext = new AppDbContext();
            Console.WriteLine("Connection succeeded!");
            var allCandidates = (from Candidate in appDbContext.Candidates
                                 select Candidate).ToList();
            foreach (var candidate in allCandidates)
            {
                Console.WriteLine(candidate.ToString());
            }
            appDbContext.Dispose();
        }
    }
}
