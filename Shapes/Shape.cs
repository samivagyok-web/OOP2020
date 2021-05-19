using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shapes
{
    internal abstract class Shape
    {
        protected Point point;

        protected Shape(Point point)
        {
            this.point = point;
        }

        public abstract void Draw();
    }
}
