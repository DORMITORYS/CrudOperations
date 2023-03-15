using CrudOperations.ApplicationDbContext;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CrudOperations.CrudMethods
{
    public class Delete
    {
        public Delete()
        {
            AppDbContext appDbContext = new AppDbContext();
            Console.Write("Enter the id of the candidate you want to delete: ");
            int id = int.Parse(Console.ReadLine());
            Console.WriteLine($"The candidate with the id {id} is:");
            Console.WriteLine(appDbContext.Candidates.Find(id));

            Console.Write($"Are you sure you want to delete the candidate with id: {id}? Type yes or no: ");
            string answer = Console.ReadLine();
            answer = answer.ToUpper();
            if (answer == "YES")
            {
                appDbContext.Candidates.Remove(appDbContext.Candidates.Find(id));
                appDbContext.SaveChanges();
            }
            else { Console.WriteLine("You are going back to the menu"); }
            appDbContext.Dispose();
        }
    }
}
