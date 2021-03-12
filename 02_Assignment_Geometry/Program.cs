using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02_Assignment_Geometry
{
    class Program
    {
        static void Main(string[] args)
        {
             Point p1 = new Point();
             Point p2 = new Point(3.0, 4.0);
            Point p3 = new Point(5, 6);
            //  Point p4 = new Point("(3.0       , 4.7    )");

            p2.MoveBy(2.4, 0.8);
            Console.WriteLine(p2);
            p2.ResetToInitialCoordinates();
            Console.WriteLine(p2);

            Line line1 = new Line(p2, p3);
            Line line2 = new Line(1.0, 2.0, 3.0, 4.0);

            Console.WriteLine(line1);
            Console.WriteLine(line1.Length);
        }
    }
}
