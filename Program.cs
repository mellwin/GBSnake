using System;
using System.Threading;

namespace ConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            //Console.SetBufferSize(80, 25);

            Walls walls = new Walls(80, 25);
            walls.Draw();

            Point p = new Point(4, 5, '*');

            Snake snake = new Snake(p, 4, Direction.RIGHT);
            snake.Draw();

            FoodCreator foodcreator = new FoodCreator(80, 25, '$');
            Point food = foodcreator.CreateFood();
            food.Draw();

            while (true)
            {
                if (walls.IsHit(snake) || snake.IsHitTail()) break;

                if (snake.Eat(food))
                {
                    food = foodcreator.CreateFood();
                    food.Draw();
                }
                else
                {
                    snake.Move();
                }
                Thread.Sleep(300);

                if (Console.KeyAvailable)
                {
                    ConsoleKeyInfo key = Console.ReadKey();
                    snake.HanleKey(key.Key);
                }
            }
        }
    }
}
