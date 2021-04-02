using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05_Assignment_Queue
{
    public class LinkedList<T>
    {
        public T val;
        public LinkedList<T> next;

        public LinkedList(T val = default(T), LinkedList<T> next = null)
        {
            this.val = val;
            this.next = next;
        }
    }
}
