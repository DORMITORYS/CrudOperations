using CrudOperations.CrudMethods;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CrudOperations
{
    internal class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Menu menu = new Menu();
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                Console.ReadLine();
            }
        }
    }
}
