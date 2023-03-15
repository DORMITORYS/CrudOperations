using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CrudOperations.CrudMethods
{
    public class Menu
    {
        public Menu()
        {
            string answer1;
            string answer2;
            string answer3;
            do
            {
                Console.Write("Are you a candidate or an administrator? Press 1 for candidare or 2 for administrator: ");
                int choice1 = int.Parse(Console.ReadLine());
                switch (choice1)
                {
                    case 1:
                        do
                        {
                            Console.WriteLine("Select the command you want to execute by entering the corresponding number.\n\n1. Read your results\n2. Extract your results in pdf.");
                            int choice2 = int.Parse(Console.ReadLine());
                            switch (choice2)
                            {
                                case 1:
                                    ReadCandidatesCertificates readCandidatesCertificates = new ReadCandidatesCertificates();
                                    break;
                                case 2:
                                    CreatePDF createPDF = new CreatePDF();
                                    break;
                                default:
                                    Console.WriteLine("invalid input");
                                    break;
                            }
                            Console.WriteLine("Press any key to continue or NO if you want to exit.");
                            answer1 = Console.ReadLine();
                            answer1 = answer1.ToUpper();
                        } while (answer1 != "NO");
                        break;
                    case 2:
                        Console.Write("Please type your password: ");
                        string password = Console.ReadLine();
                        if (password == "1234")
                        {
                            do
                            {
                                Console.WriteLine("Select the command you want to execute by entering the corresponding number.\n\n1. Create\n2. Read\n3. Update\n4. Delete\n5. view candidates results");
                                int choice3 = int.Parse(Console.ReadLine());
                                switch (choice3)
                                {
                                    case 1:
                                        Create create = new Create();
                                        break;
                                    case 2:
                                        ReadCandidates read = new ReadCandidates();
                                        break;
                                    case 3:
                                        UpdateCandidate updateCandidate = new UpdateCandidate();
                                        break;
                                    case 4:
                                        Delete delete = new Delete();
                                        break;
                                    case 5:
                                        ReadResults readResults = new ReadResults();
                                        break;
                                    default:
                                        Console.WriteLine("invalid input");
                                        break;
                                }
                                Console.WriteLine("Press any key if you want to continue or NO if you want to exit.");
                                answer2 = Console.ReadLine();
                                answer2 = answer2.ToUpper();
                            } while (answer2 != "NO");
                            Console.WriteLine("invalid input");
                        }
                        else
                        {
                            Console.WriteLine("COHONES!!!");
                        }
                        break;
                }
                Console.WriteLine("Press any key to go back to the menu or NO if you want to exit.");
                answer3 = Console.ReadLine();
                answer3 = answer3.ToUpper();
            } while (answer3 != "NO");
        }
    }
}
