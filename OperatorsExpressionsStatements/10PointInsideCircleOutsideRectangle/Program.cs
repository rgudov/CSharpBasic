using System;

class PointInsideCircleAndOutsideRectangle
{
    static void Main()
    {
        double xCircle = 0;
        double yCircle = 0;
        double r = 2;
        double d = 2 * r;
        double rectangleTop = 1;
        double x = double.Parse(Console.ReadLine());
        double y = double.Parse(Console.ReadLine());
        bool isInsideTheCircle = Math.Pow(x - xCircle, 2) + Math.Pow(y - yCircle, 2) <= d * d;
        bool isOutsideTheRectangle = (y > rectangleTop);
        if (isInsideTheCircle && isOutsideTheRectangle)
        {
            Console.WriteLine("yes");
        }
        else
        {
            Console.WriteLine("no");
        }
    }
}