using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace JustPingPong
{
    class Program
    {
        static int firstPlayerPadSize = 5;
        static int secondPlayerPadSize = 5;
        static int ballPositionX = 0;
        static int ballPositionY = 0;
        static int firstPlayerPosition = 0;
        static int secondPlayerPosition = 0;
        static int firstPlayerResult = 0;
        static int secondPlayerResult = 0;
        static bool ballDirectionUp = true; //ball move
        static bool ballDirectionRight = true; //ball move
        static Random randomGenerator = new Random();



        static void RemoveScrollbars() //remove scrollbars
        {
            Console.BufferHeight = Console.WindowHeight;
            Console.BufferWidth = Console.WindowWidth;
            Console.ForegroundColor = ConsoleColor.Magenta;
        }

        static void DrawFirstPlayer()
        {
            for (int y = firstPlayerPosition; y < firstPlayerPosition + firstPlayerPadSize; y++)
            {
                PrintAtPosition(0, y, '|');
                PrintAtPosition(1, y, '|');

            }
        }

        static void DrawSecondPlayer()
        {
            for (int y = secondPlayerPosition; y < secondPlayerPosition + secondPlayerPadSize; y++)
            {
                PrintAtPosition(Console.WindowWidth - 1, y, '|');
                PrintAtPosition(Console.WindowWidth - 2, y, '|');

            }
        }
        static void SetInialPositions()
        {
            firstPlayerPosition = Console.WindowHeight / 2 - firstPlayerPadSize / 2;
            secondPlayerPosition = Console.WindowHeight / 2 - firstPlayerPadSize / 2;
            ballPositionX = Console.BufferWidth / 2;
            ballPositionY = Console.BufferHeight / 2;
            

        }

        static void PrintAtPosition(int x, int y, char symbol)
        {
            Console.SetCursorPosition(x, y);
            Console.Write(symbol);
            
        }

       
        static void DrawBall()
        {
            PrintAtPosition(ballPositionX, ballPositionY, '@');
        }

        static void PrintResult()
        {
            
            Console.SetCursorPosition( Console.WindowWidth / 2 - 1, 0);
            Console.Write("{0} - {1}", firstPlayerResult, secondPlayerResult);
        }

        static void MoveFirstPlayerDown()
            {
                if (firstPlayerPosition < Console.WindowHeight - firstPlayerPadSize) 
                {
                    firstPlayerPosition++;
                }
                ;
            }

        static void MoveFirstPlayerUp()
        {
            if (firstPlayerPosition > 0)
            {
                firstPlayerPosition--;
            }
            
        }


        static void SetBallAtMiddle()
        {
            ballPositionX = Console.BufferWidth / 2;
            ballPositionY = Console.BufferHeight / 2;
        }

        static void MoveSecondPlayerDown()
        {
            if (secondPlayerPosition < Console.WindowHeight - secondPlayerPadSize)
            {
                secondPlayerPosition++;
            }
            ;
        }

        static void MoveSecondPlayerUp()
        {
            if (secondPlayerPosition > 0)
            {
                secondPlayerPosition--;
            }

        }

        static void SecondPlayerAIMove()
        {

            int randomNumber = randomGenerator.Next(1, 101);  // Computer chanse of stroke the ball

            if (randomNumber < 80)
            {



                if (ballDirectionUp == true)
                {
                    MoveSecondPlayerUp();
                }
                else
                {
                    MoveSecondPlayerDown();
                }
            }



        }

        static void MoveBall()  
        {
                                                                     //The bakk don`t leave the display
            if (ballPositionY == 0)                               
            {
                ballDirectionUp = false;
            }
            if (ballPositionY == Console.WindowHeight - 1)
            {
                ballDirectionUp = true;
            }

            if (ballPositionX == Console.WindowWidth - 1)  //Player 2 lost score
            {
                SetBallAtMiddle();
                ballDirectionRight = false;
                firstPlayerResult++;
                Console.SetCursorPosition(Console.WindowWidth / 2, Console.WindowHeight / 2);
                
                Console.WriteLine("First Player Wins!");
                Console.ReadKey();
                
            }
            if (ballPositionX == 0)  //Player 1 lost score
            {
                SetBallAtMiddle();
                ballDirectionRight = true;
                secondPlayerResult++;
                Console.SetCursorPosition(Console.WindowWidth / 2, Console.WindowHeight / 2);
                
                Console.WriteLine("Second Player Wins!");
                Console.ReadKey();

            }

            if (ballPositionX < 3)
            {
                if (ballPositionY >= firstPlayerPosition
                    && ballPositionY < firstPlayerPosition + firstPlayerPadSize)
                {
                    ballDirectionRight = true;
                }
            }

            // ball in pad
            if (ballPositionX >= Console.WindowWidth - 3 - 1)
            {
                if (ballPositionY >= secondPlayerPosition
                    && ballPositionY < secondPlayerPosition + secondPlayerPadSize)
                {
                    ballDirectionRight = false;
                }
            }


            if (ballDirectionUp)
            {
                ballPositionY--;
            }
            else
            {
                ballPositionY++;
            }




            if (ballDirectionRight)
            {
                ballPositionX++;
            }
            else
            {
                ballPositionX--;
            }
        }



        static void Main(string[] args)
        {



            RemoveScrollbars();
            SetInialPositions();
            while (true)
            {
                if (Console.KeyAvailable)
                {
                    ConsoleKeyInfo keyInfo = Console.ReadKey();
                    if (keyInfo.Key == ConsoleKey.UpArrow)
                    {
                        MoveFirstPlayerUp();
                    }
                    if (keyInfo.Key == ConsoleKey.DownArrow)
                    {
                        MoveFirstPlayerDown();
                    }

                }
                SecondPlayerAIMove();
                MoveBall();
                Console.Clear();
                DrawFirstPlayer();
                DrawSecondPlayer();
                DrawBall();
                PrintResult();
                Thread.Sleep(60);

                if (firstPlayerResult == 9)
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("\n\n\n\n                           Game Over!!! First Player WIN!!!");
                    return;
                    
                }
                if (secondPlayerResult == 9)
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("\n\n\n\n                           Game Over!!! Second Player WIN!!!");
                    return;
                    
                }
            }





        }

        

  
        

        
    }
}

       

