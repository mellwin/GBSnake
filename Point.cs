using System;

namespace ConsoleApp
{
    public class Point
    {
        public int x;
        public int y;
        public char sym;

        public void Draw()
        {
            Console.SetCursorPosition(x, y);
            Console.Write(sym);
        }
    }
}