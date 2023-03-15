using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tables.Models
{
    public class Candidate
    {
        public int CandidateID { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string MiddleName { get; set; }
        public string Gender { get; set; }
        public string NativeLanguage { get; set; }
        public string DateOfBirth { get; set; }
        public string PhotoIDType { get; set; }
        public string PhotoIDNumber { get; set; }
        public string PhotoIDIssueDate { get; set; }
        public string Email { get; set; }
        public string Address { get; set; }
        public string AddressLine2 { get; set; }
        public string CountryOfResidence { get; set; }
        public string State { get; set; }
        public string City { get; set; }
        public string PostalCode { get; set; }
        public string LandLineNumber { get; set; }
        public string MobileNumber { get; set; }

        public Candidate()
        {

        }

        public Candidate(int CandidateID, string FirstName, string LastName, string MiddleName, string Gender, string NativeLanguage,
                          string DateOfBirth, string PhotoIDType, string PhotoIDNumber, string PhotoIDIssueDate, string Email, string Address,
                          string AddressLine2, string CountryOfResidence, string State, string City, string PostalCode, string LandLineNumber,
                          string MobileNumber)
        {
            this.CandidateID = CandidateID;
            this.FirstName = FirstName;
            this.LastName = LastName;
            this.MiddleName = MiddleName;
            this.Gender = Gender;
            this.NativeLanguage = NativeLanguage;
            this.DateOfBirth = DateOfBirth;
            this.PhotoIDType = PhotoIDType;
            this.PhotoIDNumber = PhotoIDNumber;
            this.PhotoIDIssueDate = PhotoIDIssueDate;
            this.Email = Email;
            this.Address = Address;
            this.AddressLine2 = AddressLine2;
            this.CountryOfResidence = CountryOfResidence;
            this.State = State;
            this.City = City;
            this.PostalCode = PostalCode;
            this.LandLineNumber = LandLineNumber;
            this.MobileNumber = MobileNumber;
        }

        public Candidate(string FirstName, string LastName, string MiddleName, string Gender, string NativeLanguage,
                          string DateOfBirth, string PhotoIDType, string PhotoIDNumber, string PhotoIDIssueDate, string Email, string Address,
                          string AddressLine2, string CountryOfResidence, string State, string City, string PostalCode, string LandLineNumber,
                          string MobileNumber)
        {
            this.FirstName = FirstName;
            this.LastName = LastName;
            this.MiddleName = MiddleName;
            this.Gender = Gender;
            this.NativeLanguage = NativeLanguage;
            this.DateOfBirth = DateOfBirth;
            this.PhotoIDType = PhotoIDType;
            this.PhotoIDNumber = PhotoIDNumber;
            this.PhotoIDIssueDate = PhotoIDIssueDate;
            this.Email = Email;
            this.Address = Address;
            this.AddressLine2 = AddressLine2;
            this.CountryOfResidence = CountryOfResidence;
            this.State = State;
            this.City = City;
            this.PostalCode = PostalCode;
            this.LandLineNumber = LandLineNumber;
            this.MobileNumber = MobileNumber;
        }

        public override string ToString()
        {
            return ($"\nCandidateID: {CandidateID}, \nFirstName: {FirstName}, \nLastName: {LastName}, \nMiddleName: {MiddleName}, \nGender: {Gender}, " +
                    $"\nNativeLanguage: {NativeLanguage}, \nDateOfBirth: {DateOfBirth}, \nPhotoIDType: {PhotoIDType}, \nPhotoIDNumber: {PhotoIDNumber}, " +
                    $"\nPhotoIDIssueDate: {PhotoIDIssueDate}, \nEmail: {Email}, \nAddress: {Address}, \nAddressLine2: {AddressLine2}, " +
                    $"\nCountryOfResidence: {CountryOfResidence}, \nState: {State}, \nCity: {City}, \nPostalCode: {PostalCode}, " +
                    $"\nLandLineNumber: {LandLineNumber}, \nMobileNumber: {MobileNumber}\n\n");
        }
    }
}
