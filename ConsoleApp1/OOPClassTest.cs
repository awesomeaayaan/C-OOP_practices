using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class OOPClassTest
    {
        static void Main(string[] args)
        {
            Point p = new Point();
            p.X = 10;
            p.Y = 20;
            p.Show();

        }
    }
    class Point
    {
        private int x;
        private int y;
        public int X { get { return x; } set { x = value; } }
        public int Y { get { return y; } set { y = value; } }   
        
        public void Show()
        {
            Console.WriteLine("X=" + x);
            Console.WriteLine("Y=" + y);

        }
    }
}
