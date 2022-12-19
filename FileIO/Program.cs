using System;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;

namespace FileIO
{
    class Fil
    {
        string path = @"C:\Users\Shivam Shekhar\source\repos\Revision\FileIO\TextFile.txt";
        //string copypath = @"G:\RIvisionConcept\Revision_Concepts\FileIOStream\FileIOStream\TextCopy.txt";
        string[] lines;
        public void CheckFileExistorNot()
        {
            if (File.Exists(path))
            {
                Console.WriteLine("File Already Exist");
            }
            else
            {
                Console.WriteLine("File not found");
            }
        }
        public void Readtext()
        {
            lines = File.ReadAllLines(path);
            for (int i = 0; i < lines.Length; i++)
            {
                Console.WriteLine(lines[i]);
            }

        }

        public void ReadFromStreamReader()
        {
            using (StreamReader sr = new StreamReader(path))
            {
                String s = "";
                while ((s = sr.ReadLine()) != null)
                {
                    Console.WriteLine(s);
                }
            }
        }
        public void WriteUsingStreamWritterer()
        {
            using (StreamWriter sw = File.AppendText(path))
            {

                sw.WriteLine(" I am fine");
                sw.Close();
                Console.WriteLine(File.ReadAllText(path));
            }
        }
    }
    class program
    {
        public static void Main(string[] args)
        {
            Fil file = new Fil();
            //file.WriteUsingStreamWritterer();
            //Console.WriteLine("Hello World!");
            //file.CheckFileExistorNot();
            //file.Readtext();
            file.ReadFromStreamReader();
            file.WriteUsingStreamWritterer();
        }
    }
    
}
