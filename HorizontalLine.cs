using System.Collections.Generic;

namespace ConsoleApp
{
    public class HorizontalLine
    {
        List<Point> pList;

        public HorizontalLine(int xLeft, int xRight, int y, char sym)
        {
            pList = new List<Point>();
            for (int x = xLeft; x <= xRight; x++)
            {
                Point p = new Point(x, y, sym);
                pList.Add(p);
            }
        }

        public void Draw()
        {
            foreach (var p in pList)
            {
                p.Draw();
            }
        }
    }
}