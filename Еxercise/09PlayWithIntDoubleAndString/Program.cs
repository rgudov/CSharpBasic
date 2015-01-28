using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _09PlayWithIntDoubleAndString
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please choose type:");
            Console.WriteLine("1 --> int");
            Console.WriteLine("2 --> double");
            Console.WriteLine("3 --> string");
            int choice = int.Parse(Console.ReadLine());

            switch (choice)
            {
                case 1:
                    Console.Write("Please enter a int: ");
                    int choiceOne = int.Parse(Console.ReadLine());
                    Console.WriteLine(choiceOne + 1);
                    break;
                case 2:
                    Console.Write("Please enter a double: ");
                    double choiceTwo = double.Parse(Console.ReadLine());
                    Console.WriteLine(choiceTwo + 1);
                    break;
                case 3:
                    Console.Write("Please enter a double: ");
                    string choiceThree = Console.ReadLine();
                    Console.WriteLine(choiceThree + "*");
                    break;
            }
        }
    }
}
