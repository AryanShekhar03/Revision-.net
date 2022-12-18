using System;
using System.Text.RegularExpressions;


namespace lambd
{
    class Program
    {
        string Pattern = "^[A-Z]{1,}[a-z]{3,}$";
        public string CheckName(string name) => Regex.IsMatch(name, Pattern) ? "Name is Valid" : "Name is not Valid";
    }



    class lamda { 
    public static void Main(string[] args)
        {
            Console.WriteLine("Enter Name");
            string name = Console.ReadLine();
            Program valid = new Program();
            string user = valid.CheckName(name);
            if (user == "Name is Valid")
            {
                Console.WriteLine(user);
            }
            else
            {
                Console.WriteLine(user);
            }
        }
    }
}
