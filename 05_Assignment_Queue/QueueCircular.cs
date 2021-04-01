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
        private int size = 3;
        private int left = 0, right = 0;

        public QueueCircular()
        {
            data = new T[size];
        }

        public void Clear() => Array.Clear(data, 0, data.Length);

        public bool Contains(T searchingFor) => Array.Exists(data, element => element.Equals(searchingFor));

        public void Dequeue()
        {
            if (data[left].Equals(default(T)))
                throw new QueueEmptyException();
            else
            {
                data[left] = default(T);
                left = (left % size) + 1;
            }
        }

        public void Enqueue(T putInQ)
        {
            if (left - right == 1 || (left == 0 && right == data.Length))
                throw new QueueIsFullException();
            else
            {
                data[right % size] = putInQ;
                right++;
            }
        }

        public T Peek() => data[left];

        public int Count { get { return Array.FindAll(data, element => !element.Equals(default(T))).Length; } }
        public int Size { get { return size; } set { size = value; } }
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
