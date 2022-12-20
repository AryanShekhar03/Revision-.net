using System;

namespace stacki
{
    class Program
    {
        static void Main(string[] args)
        {
            LinkedListStackCaller();
            Console.ReadLine();

            public static void LinkedListStackCaller()
            {
                LinkListStack myStack = new LinkListStack();

                myStack.Push(10);
                myStack.Push(20);
                myStack.Push(30);
                myStack.Push(40);
                myStack.PrintStack();
                myStack.Peek();
                myStack.Pop();
                myStack.Peek();
                myStack.Pop();
                myStack.PrintStack();
            }
        }
    }
}
