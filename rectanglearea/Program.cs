using System;

namespace rectanglearea
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.Write("Rectangle Length: ");
            string rectangleLength;
            rectangleLength = Console.ReadLine();
            int rectangleLengthInt = int.Parse(rectangleLength);

            Console.Write("Rectangle Width: ");
            string rectangleWidth;
            rectangleWidth = Console.ReadLine();
            int rectangleWidthInt = int.Parse(rectangleWidth);

            int x = rectangleLengthInt * rectangleWidthInt;
            Console.WriteLine("Rectangle Area: " + " " + x);
            Console.ReadLine();



        }
    }
}
