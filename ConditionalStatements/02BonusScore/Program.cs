using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02BonusScore
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Write one number of interval 0...9 :");
            int num = int.Parse(Console.ReadLine());
            int score1 = num * 10;
            int score2 = num * 100;
            int score3 = num * 1000;

            if (num > 0 && num < 4)
            {
                Console.WriteLine("Your score is: {0}", score1);

            }
            if (num > 3 && num < 7 )
            {
                Console.WriteLine("Your score is: {0}", score2);
            }
            if (num > 6 && num < 10)
            {
                Console.WriteLine("Your score is: {0}", score3);
            }
            else
            {
                Console.WriteLine("Invalid input!");
            }



        }
    }
}
