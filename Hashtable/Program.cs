using System;
using System.Collections;

namespace HashTable
{
    public class Program
    {
       public static void Main(string[] args)
        {
            Hashtable ht = new Hashtable();
            ht.Add("1", "Aaryan");
            ht.Add("2", "shekhar");
            foreach (string key in ht.Keys)
            {
                Console.WriteLine(key + " " + ht[key]);
            }
        }
    }
}
