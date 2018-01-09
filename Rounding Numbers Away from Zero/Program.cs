using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rounding_Numbers_Away_from_Zero
{
    class Program
    {
        static void Main(string[] args)
        {
            double[] num = Console.ReadLine().Split(' ').Select(double.Parse).ToArray();
            int[] roundedNums = new int[num.Length];
            for (int i = 0; i < num.Length; i++)
            {
                roundedNums[i] = (int)Math.Round(num[i], MidpointRounding.AwayFromZero);
            }
            for (int i = 0; i < num.Length; i++)
            {

            
                Console.WriteLine($"{num[i]} -> {roundedNums[i]}");

            }
        }
    }
}
