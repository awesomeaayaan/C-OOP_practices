using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class EnumTest
    {
        static void Main(string[] args)
        {
            Console.WriteLine(WeekDays.Sunday);
            int day = (int)WeekDays.Monday;
            Console.WriteLine(day);
            var w = (WeekDays)6;
            Console.WriteLine(w);
            Console.ReadKey();

        }

    }
    enum WeekDays
    {
        Sunday,
        Monday,
        Tuesday,
        Wednesday,
        Thursday,
        Friday,
        Saturday

    }
}
