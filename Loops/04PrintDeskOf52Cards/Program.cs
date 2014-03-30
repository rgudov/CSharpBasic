using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrintDeskOf52Cards
{
    class Program
    {
        static void Main(string[] args)
        {
            string kind = "\u2660" + "\u2663" + "\u2666" + "\u2665";

            string cards = "234567891JQKA";

            for (int j = 0; j <= 12; j++)
            {
                for (int i = 0; i <= 3; i++)
                {
                    switch (i)
                    {
                        case 0:
                        case 1:
                            break;

                        case 2:
                        case 3:
                            break;
                    }

                    if (j != 8)
                    {
                        Console.Write(kind[i]);
                        Console.Write(cards[j] + "  ");
                    }
                    else
                    {
                        Console.Write(kind[i]);
                        Console.Write(cards[j] + "0  ");
                    }
                }

                Console.WriteLine();
            }
        }
    }
}
