using System;

namespace Generics
{
    public class Program<T>
    {
        private T data;

        // using properties
        public T value
        {

            // using accessors
            get
            {
                return this.data;
            }
            set
            {
                this.data = value;
            }
        }
        class Test
        {
             static void Main(string[] args)
            {
                // instance of string type
                Program<string> name = new Program<string>();
                name.value = "GeeksforGeeks";

                // instance of float type
                Program<float> version = new Program<float>();
                version.value = 5.0F;

                // display GeeksforGeeks
                Console.WriteLine(name.value);

                // display 5
                Console.WriteLine(version.value);
            }
        }
    }
}
