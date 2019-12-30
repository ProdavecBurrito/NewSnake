﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NewSnake
{
    class Figure
    {
        protected List<Point> pList;

        public void LineDraw()
        {
            foreach (Point i in pList)
            {
                i.Draw();
            }
        }
    }
}
