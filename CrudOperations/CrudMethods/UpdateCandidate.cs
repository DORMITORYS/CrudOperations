using CrudOperations.ApplicationDbContext;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CrudOperations.CrudMethods
{
    public class UpdateCandidate
    {
        public UpdateCandidate()
        {
            AppDbContext appDbContext = new AppDbContext();
            Console.Write("Enter the id of the candidate you want to update: ");
            int id = int.Parse(Console.ReadLine());
            Console.WriteLine($"The candidate with the id {id} is:");
            Console.WriteLine(appDbContext.Candidates.Find(id));

            Console.Write("\nEnter first name: ");
            string updateFirstName = Console.ReadLine();
            Console.Write("Enter last name: ");
            string updateLastName = Console.ReadLine();
            Console.Write("Enter middle name:");
            string updateMiddleName = Console.ReadLine();
            Console.Write("Enter gender: ");
            string updateGender = Console.ReadLine();
            Console.Write("Enter native language: ");
            string updateNativeLanguage = Console.ReadLine();
            Console.Write("Enter birth date: ");
            string updateDateOfBirth = Console.ReadLine();
            Console.Write("Enter photo ID type: ");
            string updatePhotoIDType = Console.ReadLine();
            Console.Write("Enter photo ID number: ");
            string updatePhotoIDNumber = Console.ReadLine();
            Console.Write("Enter photo ID issue date: ");
            string updatePhotoIDIssueDate = Console.ReadLine();
            Console.Write("Enter email: ");
            string updateEmail = Console.ReadLine();
            Console.Write("Enter street address: ");
            string updateAddress = Console.ReadLine();
            Console.Write("Enter street addressline 2: ");
            string updateAddressLine2 = Console.ReadLine();
            Console.Write("Enter country of residence: ");
            string updateCountryOfResidence = Console.ReadLine();
            Console.Write("Enter state/territory/province: ");
            string updateState = Console.ReadLine();
            Console.Write("Enter town: ");
            string updateCity = Console.ReadLine();
            Console.Write("Enter postal code: ");
            string updatePostalCode = Console.ReadLine();
            Console.Write("Enter landline number: ");
            string updateLandLineNumber = Console.ReadLine();
            Console.Write("Enter mobile number: ");
            string updateMobileNumber = Console.ReadLine();

            appDbContext.Candidates.Find(id).FirstName = updateFirstName;
            appDbContext.Candidates.Find(id).LastName = updateLastName;
            appDbContext.Candidates.Find(id).MiddleName = updateMiddleName;
            appDbContext.Candidates.Find(id).Gender = updateGender;
            appDbContext.Candidates.Find(id).NativeLanguage = updateNativeLanguage;
            appDbContext.Candidates.Find(id).DateOfBirth = updateDateOfBirth;
            appDbContext.Candidates.Find(id).PhotoIDType = updatePhotoIDType;
            appDbContext.Candidates.Find(id).PhotoIDNumber = updatePhotoIDNumber;
            appDbContext.Candidates.Find(id).PhotoIDIssueDate = updatePhotoIDIssueDate;
            appDbContext.Candidates.Find(id).Email = updateEmail;
            appDbContext.Candidates.Find(id).Address = updateAddress;
            appDbContext.Candidates.Find(id).AddressLine2 = updateAddressLine2;
            appDbContext.Candidates.Find(id).CountryOfResidence = updateCountryOfResidence;
            appDbContext.Candidates.Find(id).State = updateState;
            appDbContext.Candidates.Find(id).City = updateCity;
            appDbContext.Candidates.Find(id).PostalCode = updatePostalCode;
            appDbContext.Candidates.Find(id).LandLineNumber = updateLandLineNumber;
            appDbContext.Candidates.Find(id).MobileNumber = updateMobileNumber;
            appDbContext.SaveChanges();

            appDbContext.Dispose();
        }
    }
}
