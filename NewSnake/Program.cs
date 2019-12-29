using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NewSnake
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.SetWindowSize(80, 25);
            Console.SetBufferSize(80, 25);

            HorizontalLine upLine = new HorizontalLine(0, 78, 0, '-');
            HorizontalLine downLine = new HorizontalLine(0, 78, 24, '-');
            VerticalLine leftLine = new VerticalLine(0, 24, 0, '|');
            VerticalLine rightLine = new VerticalLine(0, 24, 78,'|');

            upLine.LineDraw();
            downLine.LineDraw();
            leftLine.LineDraw();
            rightLine.LineDraw();

            Point snake = new Point(1, 4, '*');
            snake.Draw();

            Console.ReadKey();
        }
    }
}
