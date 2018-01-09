using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Odd_Numbers_at_Odd_Positions
{
    class Program
    {
        static void Main(string[] args)
        {
            var stringArray = Console.ReadLine().Split().ToArray();
            var array = new int [stringArray.Length];
            for (int i = 1; i < array.Length; i++)
            {
                array[i] = int.Parse(stringArray[i]);
            }
            for (int i = 0; i < array.Length; i++)
            {
                if (i % 2 == 1 && Math.Abs(array[i] % 2) == 1)
                    Console.WriteLine($"Index {i} -> {array[i]}");
            }
        }

    }
}

