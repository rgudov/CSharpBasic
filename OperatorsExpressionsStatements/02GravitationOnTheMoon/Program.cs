using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02GravitationOnTheMoon
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter your weight");
            int kgEarth = int.Parse(Console.ReadLine());
            int kgMoon = (kgEarth * 17) / 100;
            Console.WriteLine("Your weight in the Moon: {0}", kgMoon);
         }
    }
}
