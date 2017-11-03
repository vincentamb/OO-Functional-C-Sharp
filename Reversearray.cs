using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp11
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] array = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
            
            Array.Reverse(array);
            Console.WriteLine("Reversed Array : ");
            foreach (int value in array)
            {
                Console.WriteLine(value);
            }
            Console.ReadLine();
        }
    }
}
