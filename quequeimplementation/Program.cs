using System;

namespace quequeimplementation
{
    class Program
    {
        static void Main(string[] args)
        {
            QueueCaller();

            Console.ReadLine();
        }
        public static void QueueCaller()
        {
            Queque queue = new Queque(100);

            QueueHelper helper = new QueueHelper();

            helper.EnQueue(queue, 10);
            helper.EnQueue(queue, 20);
            helper.EnQueue(queue, 30);
            helper.EnQueue(queue, 40);

            helper.GetFrontElement(queue);
            helper.GetRearElement(queue);

            helper.PrintQueue(queue);

            helper.DeQueue(queue);
            helper.GetFrontElement(queue);
            helper.GetRearElement(queue);

            helper.PrintQueue(queue);
        }

    }
}
