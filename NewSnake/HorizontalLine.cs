using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NewSnake
{
    class HorizontalLine
    {
        List<Point> pList;

        public HorizontalLine(int xLeft, int xRigth, int y, char sym)
        {
            pList = new List<Point>();
            for (int x = xLeft; x <= xRigth; x++)
            {
                Point p = new Point(x, y, sym);
                pList.Add(p);
            }
        }

        public void LineDraw()
        {
            foreach (Point i in pList)
            {
                i.Draw();
            }
        }
    }
}
