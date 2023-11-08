using System;

namespace ConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine(Console.LargestWindowHeight);
            //Console.WriteLine(Console.LargestWindowWidth);
            //Console.SetBufferSize(80, 25);

            HorizontalLine upLine = new HorizontalLine(0, 78, 0, '+');
            HorizontalLine downLine = new HorizontalLine(0, 78, 24, '+');
            VerticalLines leftLine = new VerticalLines(0, 24, 0, '+');
            VerticalLines rightLine = new VerticalLines(0, 24, 78, '+');
            upLine.Draw();
            downLine.Draw();
            leftLine.Draw();
            rightLine.Draw();



            Point p1 = new Point(1, 3, '*');
            p1.Draw();

            Point p2 = new Point(4,5,'#');
            p2.Draw();

            Console.ReadKey();
        }
    }
}
