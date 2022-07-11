using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class AbstractClassTest
    {
        static void Main(string[] args)
        {
            //AbsClass ab = new AbsClass();
            Derived d= new Derived();
            d.Method1();
            d.AbstractMethod();
            Console.ReadKey();


        }
    }
    abstract class AbsClass
    {
        public abstract void AbstractMethod();
        public void Method1()
        {
            Console.WriteLine("Method 1 from Absclass");
        }
    }
    class Derived : AbsClass
    {
        public override void AbstractMethod()
        {
            Console.WriteLine("Overriding AbstractMethod in derived class");
        }

    }
}
