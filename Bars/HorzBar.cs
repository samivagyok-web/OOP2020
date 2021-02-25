using System;

namespace Bars
{
    class HorzBar
    {
        private int width;
        public HorzBar(int width)
        {
            this.width = width;
            Console.Write("+");
            for (int i = 0; i < width; i++)
            {
                Console.Write("-");
            }
            Console.Write("+");
            Console.WriteLine();
        }
    }
}