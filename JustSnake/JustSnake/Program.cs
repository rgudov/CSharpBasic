using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace JustSnake
{
    struct Position
    {
        public int row;
        public int cow;
        public Position(int row, int cow)
        {
            this.row = row;
            this.cow = cow;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            byte right = 0; //massive index
            byte left = 1;
            byte down = 2;
            byte up = 3;

            Position[] directions = new Position[]
            {
                new Position(0, 1), // right
                new Position(0, -1), // left
                new Position(1, 0), // down
                new Position(-1, 0) // up
            };
            int sleepTime = 100;
            int direction = right; 
            Random randomNumberGenerator = new Random();
            Console.BufferHeight = Console.WindowHeight;
            Position food = new Position(randomNumberGenerator.Next(0, Console.WindowHeight), //food
                randomNumberGenerator.Next(0, Console.WindowWidth));

            Queue<Position> snakeElements = new Queue<Position>();

            for (int i = 0; i <= 5; i++)
            {
                snakeElements.Enqueue(new Position(0, i));
            }
            foreach (Position position in snakeElements)
                    {
                        Console.SetCursorPosition(position.cow, position.row);
                        Console.Write("*");
                    }
                while (true)
                {
                    Position snakeHead = snakeElements.Last();
                    Position nextDirection = directions[direction];
                    Position snakeNewHead = new Position(snakeHead.row + nextDirection.row,
                        snakeHead.cow + nextDirection.cow);


                    if (snakeNewHead.row < 0 || snakeNewHead.cow < 0 || snakeNewHead.row >= Console.WindowHeight
                        || snakeNewHead.cow >= Console.WindowWidth || snakeElements.Contains(snakeNewHead))
                    {
                        
                        Console.SetCursorPosition(0, 0);
                        Console.BackgroundColor = ConsoleColor.DarkRed;
                        Console.Beep();
                        Console.Beep();
                        Console.Beep();
                        Console.WriteLine("Game Over !!!");
                        Console.WriteLine("Your points are: {0}", snakeElements.Count - 6);
                        return;
                    }
                    if (snakeNewHead.cow == food.cow && snakeNewHead.row == food.row)
                    {
                        // feeding the snake
                        food = new Position(randomNumberGenerator.Next(0, Console.WindowHeight),
                            randomNumberGenerator.Next(0, Console.WindowWidth));
                        Console.Beep();
                        sleepTime--; // speed up
                    }
                    else
                    {
                        // moving...
                        snakeElements.Dequeue();
                    }

                    if (Console.KeyAvailable)
                    {
                        ConsoleKeyInfo userInput = Console.ReadKey();
                        if (userInput.Key == ConsoleKey.LeftArrow)
                        {
                            if (direction != right) direction = left;
                        }
                        if (userInput.Key == ConsoleKey.RightArrow)
                        {
                            if (direction != left) direction = right;
                        }
                        if (userInput.Key == ConsoleKey.UpArrow)
                        {
                            if (direction != down) direction = up;
                        }
                        if (userInput.Key == ConsoleKey.DownArrow)
                        {
                            if(direction != up) direction = down;
                        }
                    }

                    snakeElements.Enqueue(snakeNewHead);

                    Console.Clear();

                    foreach (Position position in snakeElements)
                    {
                        Console.SetCursorPosition(position.cow, position.row);
                        Console.Write("*");
                    }

                    Console.SetCursorPosition(food.cow, food.row);
                    Console.Write("@");

                    Thread.Sleep(sleepTime);
                }
        }
    }
}


