using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class InterfaceTest
    {
        static void Main(string[] args)
        {
            Child1 child = new Child1();
            child.Method1();
            
            Console.WriteLine("This is a interface method which is used to perfom the multiple inheritance in the c# program where not possible in the class in C#");
            Console.ReadKey();
        }
    }
    interface IFace1
    {
        void Method1();

    }
    interface Parent1
    {
        public void PMethod1()
        {
            Console.WriteLine("Method from parent1");
        }
    }
    class Child1 : IFace1, Parent1
    {
         public void Method1()
        {
            Console.WriteLine("Implementing Method1 from Interface IFace1");
        }
    }
}
