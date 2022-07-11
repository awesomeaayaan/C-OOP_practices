using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class ListTest
    {
        static void Main(string[] args)
        {
            List<string> names = new List<string>();
            names.Add("Ram");
            names.Add("hari");
            names.Add("Shyam");
            names.Add("Sita");
            names.Add("Gita");
            Console.WriteLine(names.Count);
            Console.WriteLine("-------------------");
            foreach(string name in names)
            {
                Console.WriteLine($"{name}");
            }
            Console.WriteLine("----------------------");

        }
    }
}
