using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Smallest_Element_in_Array
{
    class Program
    {
        static void Main(string[] args)
        {
            string values = Console.ReadLine();
            string[] items = values.Split(' ');
            double[] array = new double[items.Length];
            double r = 1.0;

            for (int i = 0; i < items.Length; i++)

            {
                array[i] = double.Parse(items[i]);
            }
            Array.Sort(array);

            //  for (int i = 0; i < array.Length; i++)

            Console.Write("{0} ", array[0]);
        }

    }
}

