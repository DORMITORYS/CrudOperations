using CrudOperations.ApplicationDbContext;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tables.Models;

namespace CrudOperations.CrudMethods
{
    public class Create
    {
        public Create()
        {
            AppDbContext appDbContext = new AppDbContext();
            Console.WriteLine("Connection succeeded!");

            Console.Write("Enter first name:");
            string firstName = Console.ReadLine();
            Console.Write("Enter last name:");
            string lastName = Console.ReadLine();
            Console.Write("Enter middle name: ");
            string middleName = Console.ReadLine();
            Console.Write("Enter gender:");
            string gender = Console.ReadLine();
            Console.Write("Enter native language:");
            string nativeLanguage = Console.ReadLine();
            Console.Write("Enter birth date:");
            string birthDate = Console.ReadLine();
            Console.Write("Enter photo ID type:");
            string photoIDType = Console.ReadLine();
            Console.Write("Enter photo ID number:");
            string photoIDNumber = Console.ReadLine();
            Console.Write("Enter photo ID issue date:");
            string photoIDIssueDate = Console.ReadLine();
            Console.Write("Enter email:");
            string email = Console.ReadLine();
            Console.Write("Enter street address:");
            string streetAddress = Console.ReadLine();
            Console.Write("Enter street addressline 2:");
            string streetAddressLine2 = Console.ReadLine();
            Console.Write("Enter country of residence:");
            string countryOfResidence = Console.ReadLine();
            Console.Write("Enter state/territory/province:");
            string state = Console.ReadLine();
            Console.Write("Enter town:");
            string town = Console.ReadLine();
            Console.Write("Enter postal code:");
            string postalCode = (Console.ReadLine());
            Console.Write("Enter landline number:");
            string landLineNumber = Console.ReadLine();
            Console.Write("Enter mobile number:");
            string mobileNumber = Console.ReadLine();

            appDbContext.Candidates.Add(new Candidate(firstName, lastName, middleName, gender, nativeLanguage, birthDate, photoIDType, photoIDNumber, photoIDIssueDate,
                                                      email, streetAddress, streetAddressLine2, countryOfResidence, state, town, postalCode, landLineNumber,
                                                      mobileNumber));
            appDbContext.SaveChanges();
            appDbContext.Dispose();
        }
    }
}
