using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Multiply_an_Array_of_Doubles
{
    class Program
    {
        static void Main(string[] args)
        {
            string values = Console.ReadLine();
            string[] items = values.Split(' ');
            double[] array = new double[items.Length];
            double r = 1.0;
            double n = double.Parse(Console.ReadLine());
            for (int i = 0; i < items.Length; i++)

            {
                array[i] = double.Parse(items[i]);
            }
            for (int i = 0; i < array.Length; i++)
            {
                r *= array[i];
            }
            for (int i = 0; i < array.Length; i++)
            {
                Console.Write("{0} ", array[i] * n);
            }
        }
    }
}
