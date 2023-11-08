using System;

namespace ConsoleApp
{
    public class FoodCreator
    {
        private int mapWidth;
        private int mapHeight;
        private char sym;

        private Random random = new Random();

        public FoodCreator(int _mapWidth, int _mapHeight, char _sym)
        {
            mapWidth = _mapWidth;
            mapHeight = _mapHeight;
            sym = _sym;
        }

        public Point CreateFood()
        {
            int x = random.Next(2, mapWidth - 2);
            int y = random.Next(2, mapHeight - 2);
            return new Point(x, y, sym);
        }
    }
}