using System.Collections.Generic;

namespace ConsoleApp
{
    public class Figure
    {
        protected List<Point> pList;

        public void Draw()
        {
            foreach (var p in pList)
            {
                p.Draw();
            }
        }
    }
}