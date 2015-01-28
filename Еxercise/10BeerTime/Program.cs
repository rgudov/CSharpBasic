using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10BeerTime
{
    class Program
    {
        static void Main(string[] args)
        {
            DateTime beerTime = DateTime.Parse(Console.ReadLine());
            string sign = beerTime.ToString("tt");

            if (beerTime.Hour < 12)
            {
                if (sign == "AM")
                {
                    if (beerTime.Hour >= 3 && beerTime.Minute >= 0 && beerTime.Minute < 60)
                    {
                        Console.WriteLine("non-beer time");
                    }
                    else
                    {
                        Console.WriteLine("beer time");
                    }
                }
                else if (sign == "PM")
                {
                    if (beerTime.Hour - 12 >= 1)
                    {
                        Console.WriteLine("beer time");
                    }
                    else
                    {
                        Console.WriteLine("non-beer time");
                    }
                }
            }
            else
            {
                Console.WriteLine("invalid time");
            }
        }
    }
}
