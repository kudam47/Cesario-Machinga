using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Micro_Bank
{

    class Program
    {

        static void Main(string[] args)
        {

            Console.Write("Please enter your Firstname : ");
            string userFirstname = Console.ReadLine();

            Console.Write("Please enter your Secondname : ");
            string userSecondname = Console.ReadLine();

            Console.Write("Please enter your ID number: ");
            string userIDnumber = Console.ReadLine();

            Console.Write("Please enter your Date of Birth : ");
            string userDateofBirth = Console.ReadLine();

            Console.WriteLine("Hello {0} {1} please fill in the pasword.", userFirstname, userSecondname);

            Console.Write("Please create your New Pasword : ");
            string userNewPasword = Console.ReadLine();

            Console.Write("Please reenter your Pasword : ");
            string userPasword = Console.ReadLine();

            Console.Write("Please input Start Amount : $ ");
            string userStartAmount = Console.ReadLine();

            Console.WriteLine("Hello {0}!{1} you have successfully regisered your new bank account, please fill in the following details so that you will recieve notifications regarding the transaction you will make.", userFirstname, userSecondname);

            Console.Write("Please input Cell number : ");
            string userCellnumber = Console.ReadLine();

            Console.Write("Please input Email Address : ");
            string userEmailAddress = Console.ReadLine();

            Console.Write("Please input Home Address for paperwork : ");
            string userHomeAddress = Console.ReadLine();

        }

    }

}
