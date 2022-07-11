using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Car
    {
        string CarModel;
        int CarYear;
        public Car(string Model, int Year)
        {
            CarModel = Model;
            CarYear = Year;
        }
        public Car( int Year, string Model)
        {
            CarModel = Model;
            CarYear = Year;
        }
        static void Main(string[] args)
        {
            Car myCar = new Car(1967, "Impala");
           
            Console.WriteLine("Model:"+ myCar.CarModel);
            Console.WriteLine("Year:"+ myCar.CarYear);
            Console.ReadLine();
        }
    }
}
