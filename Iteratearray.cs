using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp7
{
    class Iterate
    {
        static void Main(string[] args)
        {
            int[] arr = { 1, 2, 3, 4, 5 };
            int[] arr2 = arr.Select(el => el*2).ToArray();

            foreach (var str in arr2)
                Console.Write(str + " ");
            Console.ReadLine();

        }
    }
}
