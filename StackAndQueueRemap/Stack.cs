using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StackAndQueueRemap
{
    public class Stack
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
        public void print()
        {
            linkedlist.display();
        }
        public void peek()
        {
            Console.WriteLine(linkedlist.peek());
        }

        public bool isEmpty()
        {
            if (linkedlist.size() == 0)
                return true;
            else
                return false;
        }

        public int pop()
        {
            return linkedlist.pop();
        }
    }
}
