using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05_Assignment_Queue
{
    public class LinkedList
    {
        public int val;
        public LinkedList next;

        public LinkedList(int val = 0, LinkedList next = null)
        {
            this.val = val;
            this.next = next;
        }
    }
}
