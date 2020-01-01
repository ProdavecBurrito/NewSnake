using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NewSnake
{
    class Snake : Figure
    {
         Direction direction;
        public Snake (Point tail, int length, Direction _direction)
        {
            direction = _direction;
            pList = new List<Point>();
            for (int i = 0; i < length; i++)
            {
                Point p = new Point(tail);
                p.Move(i, direction);
                pList.Add(p);
            }
        }

        internal void Move()
        {
            Point tail = pList.First();
            pList.Remove(tail);
            Point head = GetNextPoint();
            pList.Add(head);

            tail.Clear();
            head.Draw();
        }

        public Point GetNextPoint()
        {
            Point head = pList.Last();
            Point nextPoint = new Point(head);
            nextPoint.Move(1, direction);
            return nextPoint;
        }

        public void HandleKey(ConsoleKey key)
        {
            if (key == ConsoleKey.LeftArrow || key == ConsoleKey.A)
            {
                direction = Direction.LEFT;
            }
            else if (key == ConsoleKey.RightArrow || key== ConsoleKey.D)
            {
                direction = Direction.RIGHT;
            }
            else if (key == ConsoleKey.UpArrow || key == ConsoleKey.W)
            {
                direction = Direction.UP;
            }
            else if (key == ConsoleKey.DownArrow || key == ConsoleKey.S)
            {
                direction = Direction.DOWN;
            }
        }
    }
}
