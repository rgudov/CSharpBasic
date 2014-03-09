using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HangmanGame
{
    class Program
    {
        static void Main(string[] args)
        {
          //champion
            char c = 'c';
            char h = 'h';
            char a = 'a';
            char m = 'm';
            char p = 'p';
            char i = 'i';
            char o = 'o';
            char n = 'n';

            char hiddenChar = '_';

            bool isCShown = false;
            bool isHShown = false;
            bool isAShown = false;
            bool isMShown = false;
            bool isPShown = false;
            bool isIShown = false;
            bool isOShown = false;
            bool isNShown = false;

            //erroes
            int livesCount = 3;

            Console.WriteLine("This is the commands: view, guess, restart");
            Console.WriteLine("_ _ _ _ _ _ _ _");
            while (true)
            {
                
                Console.Write("Enter command: ");
                string command = "";
                command = Console.ReadLine();

                
                Console.WriteLine();


                if (command == "view")
                {
                    Console.WriteLine("Your lives is {0}" ,livesCount);
                }
                
                if (command == "guess")
                {
                    Console.Write("Enter latter: ");
                    char latter = Char.Parse(Console.ReadLine());

                    if (latter == c)
                    {
                        if (!isCShown)
                        {
                            isCShown = true;
                        }

                        else
                        {
                            Console.WriteLine("You already revealed this letter");
                        }

                    }

                    if (latter == h)
                    {
                        if (!isHShown)
                        {
                            isHShown = true;
                        }

                        else
                        {
                            Console.WriteLine("You already revealed this letter");
                        }

                    }

                    if (latter == a)
                    {
                        if (!isAShown)
                        {
                            isAShown = true;
                        }

                        else
                        {
                            Console.WriteLine("You already revealed this letter");
                        }

                    }

                    if (latter == m)
                    {
                        if (!isMShown)
                        {
                            isMShown = true;
                        }

                        else
                        {
                            Console.WriteLine("You already revealed this letter");
                        }

                    }

                    if (latter == p)
                    {
                        if (!isPShown)
                        {
                            isPShown = true;
                        }

                        else
                        {
                            Console.WriteLine("You already revealed this letter");
                        }

                    }

                    if (latter == i)
                    {
                        if (!isIShown)
                        {
                            isIShown = true;
                        }

                        else
                        {
                            Console.WriteLine("You already revealed this letter");
                        }

                    }

                    if (latter == o)
                    {
                        if (!isOShown)
                        {
                            isOShown = true;
                        }

                        else
                        {
                            Console.WriteLine("You already revealed this letter");
                        }

                    }

                    if (latter == n)
                    {
                        if (!isNShown)
                        {
                            isNShown = true;
                        }

                        else
                        {
                            Console.WriteLine("You already revealed this letter");
                        }

                    }


                    if (latter != c && latter != h && latter != a && latter != m && latter != p && latter != i && latter != o && latter != n)
                    {
                        livesCount--;
                        Console.WriteLine("You are mistake! Your live is {0}", livesCount);
                    }
                    // Game over
                   
                    if (livesCount == 0)
                    {
                        Console.Clear();
                        isCShown = false;
                        isHShown = false;
                        isAShown = false;
                        isMShown = false;
                        isPShown = false;
                        isIShown = false;
                        isOShown = false;
                        isNShown = false;
                        livesCount = 3;
                        Console.WriteLine("Game over! Try again!");
                        
                    }

                    
                    if (isCShown)
                    {
                        Console.Write("{0} ", c);
                    }
                    else
                    {
                        Console.Write("{0} ", hiddenChar);
                    }


                    if (isHShown)
                    {
                        Console.Write("{0} ", h);
                    }
                    else
                    {
                        Console.Write("{0} ", hiddenChar);
                    }

                    if (isAShown)
                    {
                        Console.Write("{0} ", a);
                    }
                    else
                    {
                        Console.Write("{0} ", hiddenChar);
                    }

                    if (isMShown)
                    {
                        Console.Write("{0} ", m);
                    }
                    else
                    {
                        Console.Write("{0} ", hiddenChar);
                    }

                    if (isPShown)
                    {
                        Console.Write("{0} ", p);
                    }
                    else
                    {
                        Console.Write("{0} ", hiddenChar);
                    }

                    if (isIShown)
                    {
                        Console.Write("{0} ", i);
                    }
                    else
                    {
                        Console.Write("{0} ", hiddenChar);
                    }

                    if (isOShown)
                    {
                        Console.Write("{0} ", o);
                    }
                    else
                    {
                        Console.Write("{0} ", hiddenChar);
                    }

                    if (isNShown)
                    {
                        Console.Write("{0} ", n);
                    }
                    else
                    {
                        Console.Write("{0} ", hiddenChar);
                    }
                    Console.WriteLine();


                    if (isCShown && isHShown && isAShown && isMShown && isPShown && isIShown && isOShown && isNShown)
                    {
                        isCShown = false;
                        isHShown = false;
                        isAShown = false;
                        isMShown = false;
                        isPShown = false;
                        isIShown = false;
                        isOShown = false;
                        isNShown = false;
                        livesCount = 3;
                        Console.Clear();
                        Console.WriteLine("<<  You won! Play agane :) >>");
                    }


                }
                // restart with ctr+o
                if (command == "restart")
                {
                    Console.WriteLine("Do you really want to restart? ");
                    ConsoleKeyInfo key = Console.ReadKey();
                    if (key.Modifiers == ConsoleModifiers.Control && key.Key == ConsoleKey.O)
                    {
                        isCShown = false;
                        isHShown = false;
                        isAShown = false;
                        isMShown = false;
                        isPShown = false;
                        isIShown = false;
                        isOShown = false;
                        isNShown = false;
                        livesCount = 3;
                        Console.Clear();
                        Console.WriteLine("<<  You just restart the game! >>");
                    }
                }
            }

            
        }
        
    }
}
