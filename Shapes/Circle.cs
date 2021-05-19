using System;
using System.Text;

namespace Shapes
{ 
    internal class Circle : Shape
    {
        private int radius;

        public Circle(Point point, int radius) : base(point)
        {
            this.point = point;
            this.radius = radius;
        }

        public Circle(int radius) : this(new Point(0,0), radius)
        {
            
        }

        public override void Draw()
        {
            Console.WriteLine($"Drawing Circle: {this}");
        }

        public override string ToString()
        {
            return new StringBuilder().
                Append($"[Center = {point.ToString()}; Radius = {radius}]").
                ToString();
        }
    }
}