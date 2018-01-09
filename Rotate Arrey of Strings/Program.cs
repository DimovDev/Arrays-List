using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rotate_Arrey_of_Strings
{
    class Program
    {
        static void Main(string[] args)
        {
            var array = Console.ReadLine().Split().ToArray();
            var rotatedArrey = new string[array.Length];
            for (int i = 0; i < array.Length/2; i++)
            
            {
                SwapElements(array,i,array.Length-1-i);
            }
            Console.WriteLine(string.Join(" ",array));
        }

        private static void SwapElements(string[] array, int i, int j)
        {
            var oldElement = array[i];
            array[i] = array[j];
            array[j] = oldElement;
         //  throw new NotImplementedException();
        }
    }
}
