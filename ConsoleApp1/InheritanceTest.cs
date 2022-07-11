using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class InheritanceTest
    {
        static void Main(string[] args)
        {
            ChildClass cc = new ChildClass();
            cc.print();
            Console.ReadKey();

        }

    }
    public class ParentClass
    {
        public int x = 20;
       public ParentClass()
        {
            Console.WriteLine("Parent Constructor");
        }
        public void print()
        {
            Console.WriteLine("This is the method from parent class");
        }
    }
    public class ChildClass:ParentClass
    {
        public ChildClass()
        {
            Console.WriteLine("This is your child constructor");
            base.print();
            Console.WriteLine(base.x);
        }
    }
}
