using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05_Assignment_Queue
{
    class Program
    {
        static void Main(string[] args)
        {
            Queue<int> a = new Queue<int>();

            QueueLL<int> b = new QueueLL<int>();
            b.Enqueue(2);
            b.Enqueue(4);
            b.Enqueue(5);
        }
    }
}
