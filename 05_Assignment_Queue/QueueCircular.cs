using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace _05_Assignment_Queue
{
    public class QueueCircular<T> : Q<T>
    {
        private T[] data;
        private readonly int size;
        private int count = 0;
        private int left = 0, right = 0;

        public QueueCircular() : this(3)
        {

        }

        public QueueCircular(int size)
        {
            data = new T[size];
            this.size = size;
        }

        public void Clear() => Array.Clear(data, 0, data.Length);

        public bool Contains(T searchingFor) => Array.Exists(data, element => element.Equals(searchingFor));

        public T Dequeue()
        {
            if (this.IsEmpty)
                throw new QueueEmptyException();
            else
            {
                count--;
                T dequeuedMember = data[left];
                data[left] = default(T);
                left = (left + 1) % size;
                return dequeuedMember;
            }
        }

        public void Enqueue(T putInQ)
        {
            if (this.IsFull)
                throw new QueueIsFullException();
            else
            {
                count++;
                data[right % size] = putInQ;
                right = (right + 1) % size;
            }
        }

        public T Peek() => data[left];

        public int Count { get { return count; } }
        public bool IsEmpty { get { return count == 0; } }
        public bool IsFull { get { return count == size; } }
        public int Size { get { return size; } }
        public T[] Data { get { return data; } }
    }



    [Serializable]
    internal class QueueIsFullException : Exception
    {
        public QueueIsFullException()
        {
        }

        public QueueIsFullException(string message) : base(message)
        {
        }

        public QueueIsFullException(string message, Exception innerException) : base(message, innerException)
        {
        }

        protected QueueIsFullException(SerializationInfo info, StreamingContext context) : base(info, context)
        {
        }
    }

    [Serializable]
    internal class QueueEmptyException : Exception
    {
        public QueueEmptyException()
        {
        }

        public QueueEmptyException(string message) : base(message)
        {
        }

        public QueueEmptyException(string message, Exception innerException) : base(message, innerException)
        {
        }

        protected QueueEmptyException(SerializationInfo info, StreamingContext context) : base(info, context)
        {
        }
    }
}
