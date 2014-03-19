using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05FormatNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = int.Parse(Console.ReadLine());
            if ((a > -1) && (a < 501))
            {

            }
            else
            {
                Console.WriteLine("Invalid input! |a(0 ≤ a ≤ 500)|");
                return;
            }

            float b = float.Parse(Console.ReadLine());
            float c = float.Parse(Console.ReadLine());

            Console.WriteLine("|{0, -10:X}|{1, 10}|{2, 10:F2}|{3, -10:F3}|", a, Convert.ToString(a, 2).PadLeft(10, '0'), b, c);







        }
    }
}
