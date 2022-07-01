// See https://aka.ms/new-console-template for more information
using System;
namespace DataStructuresDemo
{
    class program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("HelloWorld!");
            LinkedListStack linkedliststack = new LinkedListStack();
            linkedliststack.push(56);
            linkedliststack.push(30);
            linkedliststack.push(70);
            linkedliststack.peek();
            linkedliststack.pop();
            linkedliststack.IsEmpty();
            linkedliststack.Display();
        }
    }
}



