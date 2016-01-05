using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SnakeMyVersion
{
    class Program
    {
        static void Main(string[] args)
        {
            Point p1 = new Point(1, 3, '*');
            p1.Draw();

            Point p2 = new Point(4, 5, '#');
            p2.Draw();

            HorizontalLine hLine = new HorizontalLine(0, 20, 8, '_');
            hLine.Draw();

            VerticalLine vLine = new VerticalLine(0, 10, 20, '|');
            vLine.Draw();

            Console.ReadLine();
        }

    }

}
