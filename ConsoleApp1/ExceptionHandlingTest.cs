using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class ExceptionHandlingTest
    {
        static void Main(string[] args)
        {
            try
            {
                int a = 10;
                int b = 0;
                int c = a / b;
                Console.WriteLine("The value of c=" + c);
            }
            catch (DivideByZeroException e1)
            { 
                Console.WriteLine(e1.ToString());
            
            }
            finally
            {
                Console.WriteLine("This is Last Line");
            }
            Console.ReadKey();
            
        }
    }
}
