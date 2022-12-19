using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace stackimplementation
{
    class Program
    {
        static void Main(string[] args)
        {

           StackCaller();
            Console.ReadLine();
        }
        public static void StackCaller()
        {
            stack myStack = new stack();

            myStack.Push(10);
            myStack.Push(20);
            myStack.Push(30);
            myStack.Push(40);
            myStack.PrintStack();
            myStack.Peek();
            myStack.Pop();
            myStack.Peek();
            myStack.PrintStack();
        }
    }
}
