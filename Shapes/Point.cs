using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shapes
{
    public class Point
    {
        private readonly int x, y;

        public Point(int x, int y)
        {
            this.x = x;
            this.y = y;
        }
        
        public int X { get { return x; } }
        public int Y { get { return y; } }

        public override string ToString()
        {
            return new StringBuilder().Append($"({x}, {y})").ToString();
        }
    }
}
