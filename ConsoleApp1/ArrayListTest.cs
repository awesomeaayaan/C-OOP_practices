using System;
using System.Collections.Generic;  
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace ConsoleApp1
{
    internal class ArrayListTest
    {
        static void Main(string[] args)
        {
            ArrayList a1 = new ArrayList();
            Object O = "A1";
            a1.Add("s1");
            a1.Add(1);
            a1.Add(3.5);
            a1.Add(0);

            Console.WriteLine(a1.Count);

            string s1 = (string)a1[0];
            int i = (int)a1[1];
            foreach(Object item in a1)
            {
                Console.WriteLine(item);
            }

            Console.WriteLine(a1.IndexOf(1));
            a1.Remove(1);
            a1.RemoveAt(0);
            Console.WriteLine(a1.Count);
            Console.ReadKey();
        }
    }
}
