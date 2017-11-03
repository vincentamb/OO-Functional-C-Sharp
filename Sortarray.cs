using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp10
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] values = { 4, 3, 2, 1 };
            Array.Sort(values);
            foreach (int value in values)
            {
                Console.WriteLine(value);
            }
            Console.ReadLine();
        }
    }
}
