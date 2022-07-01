using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace stack
{
    internal class LinkedListStack
    {
        public Node top;
        public LinkedListStack()
        {
            this.top == null;
        }
        internal void push(int value)
        {
            Node node = new Node(value);
            if (this.top == null)
            {
                node.next = null;
            }
            else
            {
                node.next = this.top;

            }
            this.top = node;
            Console.WriteLine("{0} pushed to stack ", value);

        }
        internal void Display()
        {
            Node temp = this.top;
            while (temp != null)
            {
                Console.WriteLine(temp.data + " ");
                temp = temp.next;
            }
        }

        internal void peek()
        {
            if (this.top == null)
            {
                Console.WriteLine("stack is empty");
                return;
            }
            Console.WriteLine("{0} is in the top of the stack", this.top.data);

        }
        internal void pop()
        {
            if (this.top == null)

            {
                Console.WriteLine("stack is empty, Deletion is not possible");
                return;
            }
            Console.WriteLine("value popped is {0}" this.top.data);
            this.top = this.top.next;
        }

        internal void IsEmpty();
        {
             while (this.top ! = null)
            {
            peek();
            pop();
        }
        }
    }
}
      
        

