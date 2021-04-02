using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05_Assignment_Queue
{
    class QueueLL<T> : Q<T>
    {
        private int size = 42;
        private int count = 0;
        private LinkedList<T> head, copy;

        public QueueLL()
        {
            head = new LinkedList<T>(); // Linked List with a dummy node as first element
            copy = new LinkedList<T>(); // reference to the head of the Linked List
        }

        public void Clear() => head = new LinkedList<T>(); // ok

        public bool Contains(T searchingFor)
        {
            while (head.next != null)
            {
                if (head.val.Equals(searchingFor))
                    return true;
            }
            return false;
        }

        public T Dequeue()
        {
            if (count == 0)
                throw new QueueEmptyException();
            else
            {
                T toReturn = head.next.val;
                head.next = head.next.next;
                count--;
                return toReturn;
            }
        }

        public void Enqueue(T putInQ)
        {
            if (count >= size)
                throw new QueueIsFullException();
            else
            {
                head.next = new LinkedList<T>(putInQ);
                appendToEndOfLL(copy);
                head = head.next;
                count++;
            }
        }

        public T Peek() => copy.next.val;   //  ok

        private void appendToEndOfLL(LinkedList<T> LL)
        {

        }
    }
}
