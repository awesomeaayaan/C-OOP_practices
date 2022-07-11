using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Calculator
    {
        int num1;
        int num2;
        int result;

        void Add()
        {
            result = num1 + num2; 
            Console.WriteLine(result);
            Console.ReadLine();

        }
        void Subtract()
        {
            result = num1 - num2;
            Console.WriteLine(result);
            Console.ReadLine();

        }
       public static void Main(string[] args)
        {
            Calculator c = new Calculator();
            c.num1 = 12;
            c.num2 = 13;
            c.Add();
            c.Subtract();
            Console.WriteLine("result");
            Console.ReadLine();
        }
    }
}
