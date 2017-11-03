using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp8
{
    class Program
    {
        static void Main(string[] args)
        {
            int sum = 0;
            int[] arr = new int[3] { 1, 2, 3 };
            for (int i = 0; i < arr.Length; i++)
            {
                sum += arr[i];

            }
            Console.WriteLine(sum);
            Console.ReadLine();
        }
    }
}
