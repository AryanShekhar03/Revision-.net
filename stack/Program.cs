using System;
using System.Collections;

namespace stack
{
    class Program
    {
        public static void Main(string[] args)
        {
            Stack list = new Stack();
            list.Push(1);
            list.Push(2);
            list.Push("abc");
            list.Pop();
            foreach (var item in list)
            {
                Console.WriteLine(item);
            }
        }
    }
}
