using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace ConsoleApp1
{
    internal class FileReadWrite
    {
        static void Main(string[] args)
        {
            File.WriteAllText("myfile1.txt", "This is my text for the file myfile1.txt");
            string myText = File.ReadAllText("myfile1.txt");
            Console.WriteLine(myText);
            Console.ReadKey();
        }
    }
}
