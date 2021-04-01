using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using _05_Assignment_Queue;

namespace QueueCircularTest
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void QueueEnqueueDequeueValid()
        {
            // Arrange
            QueueCircular<int> qTest = new QueueCircular<int>();
            qTest.Size = 3;
            qTest.Enqueue(5);
            qTest.Enqueue(6);
            qTest.Dequeue();
            qTest.Enqueue(7);
            qTest.Enqueue(8);

            int[] expected = { 8, 6, 7 };

            // Act
            int[] actual = qTest.Data;
            // Assert
            CollectionAssert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void ContainsTestValid()
        {
            QueueCircular<int> qTest = new QueueCircular<int>();

            qTest.Enqueue(5);
            qTest.Enqueue(6);
            qTest.Dequeue();
            qTest.Enqueue(7);
            qTest.Enqueue(8);

            bool expected = true;

            bool actual = qTest.Contains(8);

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void ClearTestValid()
        {
            QueueCircular<int> qTest = new QueueCircular<int>();

            qTest.Enqueue(5);
            qTest.Enqueue(6);
            qTest.Dequeue();
            qTest.Enqueue(7);

            int[] expected = { 0, 0, 0 };
            qTest.Clear();
            int[] actual = qTest.Data;

            CollectionAssert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void PeekTestValid()
        {
            QueueCircular<int> qTest = new QueueCircular<int>();

            qTest.Enqueue(5);
            qTest.Enqueue(6);
            qTest.Dequeue();
            qTest.Enqueue(7);

            int expected = 6;

            int actual = qTest.Peek();

            Assert.AreEqual(expected, actual);
        }
    }
}
