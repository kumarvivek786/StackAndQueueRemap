using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StackAndQueueRemap
{
    internal class Stack
    {
        public LinkedList linkedlist;

        public Stack()
        {
            this.linkedlist = new LinkedList();
        }

        public void push(int data)
        {
            linkedlist.add(data);
            Console.WriteLine("{0} pushed to stack ", data);
        }
    }
}
