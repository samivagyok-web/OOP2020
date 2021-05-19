using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shapes
{
    internal class Rectangle : Shape
    {
        private int _width;
        private int _height;

        public Rectangle(Point point, int width, int heigth) : base(point)
        {
            _width = width;
            _height = heigth;
        }

        public Rectangle(int x1, int y1, int x2, int y2) : 
            this(new Point(x1, y1), Math.Abs(x1 - x2), Math.Abs(y1 - y2))
        {

        }

        public override void Draw()
        {
            Console.WriteLine($"Drawing rectangle: {this}");
        }

        public override string ToString()
        {
            return new StringBuilder().Append($"[Origin = {point.ToString()}; Width = {_width}; Height = {_height}]").ToString();
        }
    }
}
