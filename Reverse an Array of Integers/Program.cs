using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Reverse_an_Array_of_Integers
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int [] arr = new int[n];
            for (int i = 0; i < n; i++)
             //   sortarr=new int;
            {
                arr[i] = int.Parse(Console.ReadLine());
            }
            // int []sortarr = new int[ n];
            for (int i = n-1; i >= 0; i--)
            {
                Console.WriteLine(arr[i]);
            }
        }
    }
}
