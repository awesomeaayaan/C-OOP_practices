using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class DelegateTest
    {
        public delegate void SimpleDelegate();
            static void Main(string[] args)
        {
            SimpleDelegate d = new SimpleDelegate(F1);
            d();
        }
        static void F1()
        {
            Console.WriteLine("This is called by delegate");
            Console.ReadKey();
        }
    }
}
