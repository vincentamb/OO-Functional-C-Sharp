using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp12
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] a = { 1, 2, 3 };
            int[] b = { 4, 5, 6 };
            var list = new List<int>();
            list.AddRange(a);
            list.AddRange(b);
            int[] c = list.ToArray();
            Console.WriteLine("New Array is:");
            foreach (int element in c)
            {
                Console.WriteLine(element);
            }
            Console.ReadLine();
        }
    }
}
