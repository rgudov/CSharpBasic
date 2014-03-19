using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02PrintCompanyInformation
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the company has name, address, phone number,\nfax number, web site and manager(first name, \nlast name, age and phone number:");
            string companyName = (Console.ReadLine());
            string adress = (Console.ReadLine());
            string companyNumber = (Console.ReadLine());
            string fax = (Console.ReadLine());
            string website = (Console.ReadLine());
            string firstName = (Console.ReadLine());
            string lastName = (Console.ReadLine());
            byte age = byte.Parse(Console.ReadLine());
            string managerNumber = (Console.ReadLine());

            Console.WriteLine("Company information:");
            Console.WriteLine("Name: {0}",companyName);
            Console.WriteLine("Adress: {0}",adress);
            Console.WriteLine("Phone number: {0}",companyNumber);
            Console.WriteLine("Fax number: {0}",fax);
            Console.WriteLine("Web site: {0}",website);
            Console.WriteLine("Manager information:");
            Console.WriteLine("First name: {0}",firstName);
            Console.WriteLine("Last name: {0}",lastName);
            Console.WriteLine("Age: {0}",age);
            Console.WriteLine("Phone number: {0}",managerNumber);



        }
    }
}


//A company has name, address, phone number, fax number, web site and manager. 
//The manager has first name, last name, age and a phone number. Write a program
//that reads the information about a company and its manager and prints it back on
//the console.