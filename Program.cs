using System;
using System.Threading;

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

            Point p = new Point(4, 5, '*');
            p.Draw();

            Snake snake = new Snake(p, 4, Direction.RIGHT);
            snake.Draw();

            Thread.Sleep(300);
            snake.Move();

            Thread.Sleep(300);
            snake.Move();

            Thread.Sleep(300);
            snake.Move();

            Thread.Sleep(300);
            snake.Move();

            Console.ReadKey();
        }
    }
}
