using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class IndexerTest
    {
        static void Main(string[] args)
        {
            Student s1 = new Student();
            s1.Roll = 1;
            s1[0] = 45;
            s1[2] = 50;
            Console.WriteLine(s1.GetPercent());

            Student s2 = new Student();
            s2.Roll = 2;
            s2[0] = 55;
            Console.WriteLine(s2.GetPercent());
            Console.ReadKey();

        }
    }
    class Student { 
    private int roll;
    public int Roll
    {
        get { return roll; }
        set { roll = value; }
    }
    private int[] marks = new int[3];
        public int this[int index]
    {
        get { return marks[index]; }
        set { marks[index] = value; }
    }
        public double GetPercent()
        {
            double total=0.0;
            foreach(int m in marks)
            {
                total = total + m;

            }
            return total/ marks.Length;


        }
    }
}
