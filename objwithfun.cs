using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp5
{
   class Car
    {
        public int wheels, engines, seats;
        public Car()
        {
            wheels = 4;
            engines = 1;
            seats = 5;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Car obj = new Car();
            Console.WriteLine("Wheels:" + obj.wheels);
            Console.WriteLine("Engines:" + obj.engines);
            Console.WriteLine("Seats:" + obj.seats);
            Console.ReadLine();
        }
    }
}
