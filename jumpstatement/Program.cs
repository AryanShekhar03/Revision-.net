using System;

namespace jumpstatement
{
    public class Program
    {
       public static void Main(string[] args)
        {
        //break 
        //for (int i = 0; i < 10; i++)
        //{
        //    Console.Write(" " + i);
        //    if (i == 5) break;
        //}

        //continue
        //for (int j = 0; j < 10; j++)
        //{
        //    if (j == 5) continue;
        //    Console.Write(" " + j);
        //}


        //goto
        int i = 0;  
        lableX: Console.WriteLine("lable construct" + i++);

            if (i < 5)
                goto lableX;
        }
    }
}
