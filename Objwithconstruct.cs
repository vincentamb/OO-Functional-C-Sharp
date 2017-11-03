using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp6
{
    class Car
    {
        public int wheels, engines, seats;
        public string nickname;
        public Car()
        {
            wheels = 4;
            engines = 1;
            seats = 7;
            nickname = "Nicky";
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
        Car obj = new Car();
        Console.WriteLine("wheels:" + obj.wheels);
        Console.Write("Nick Name:" + obj.nickname);
        Console.ReadLine();
        }
    }
}
