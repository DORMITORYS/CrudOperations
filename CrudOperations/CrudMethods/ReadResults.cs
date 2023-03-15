using CrudOperations.ApplicationDbContext;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CrudOperations.CrudMethods
{
    public class ReadResults
    {
        public ReadResults()
        {
            AppDbContext appDbContext = new AppDbContext();
            Console.WriteLine("Connection succeeded!");
            var allResults = (from Result in appDbContext.Results
                              select Result).ToList();
            foreach (var result in allResults)
            {
                Console.WriteLine(result.ToString());
            }
            appDbContext.Dispose();
        }
    }
}
