using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05_Assignment_Queue
{
    public interface Q<T>
    {
        void Enqueue(T putInQ);
        void Dequeue();
        void Clear();
        T Peek();
        bool Contains(T searchingFor);
    }
}
