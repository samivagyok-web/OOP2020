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
            QueueCircular<int> asd = new QueueCircular<int>();
            
            asd.Enqueue(5);
            asd.Enqueue(6);
            asd.Dequeue();
            asd.Enqueue(7);
            asd.Enqueue(8);
            Console.WriteLine(asd.Count);
            asd.Dequeue();
            asd.Contains(7);
            asd.Clear();
        }
    }
}
