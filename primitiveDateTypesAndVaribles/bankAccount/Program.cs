using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bankAccount
{
    class Program
    {
        static void Main(string[] args)
        {
            
            Console.WriteLine("Enter your full name(first name/enter, middle name/enter and last name/enter");
            string firstName = (Console.ReadLine());
            string middleName = (Console.ReadLine());
            string lastName = (Console.ReadLine());
            string iban = "BG32 UBBS 7827 1013 6179 05";
            string bank = "First Investment Bank";
            Console.WriteLine("Hello {0} {1} {2} in {3}(BankIban: {4}",firstName, middleName, lastName, bank,iban);
            decimal ballance = -0.00000000000001m;
            long cardNumber1 = 123456789123509;
            long cardNumber2 = 908765432123456;
            long cardNumber3 = 574836123456789;
            Console.WriteLine("You have tree credit cards: \n{0}\n{1}\n{2}", cardNumber1, cardNumber2, cardNumber3);
            Console.WriteLine("Your ballance is: {0}", ballance);
            Console.WriteLine("Have a nace day! :)");


            
        }
    }
}
