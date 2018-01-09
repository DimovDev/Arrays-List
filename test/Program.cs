using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace test
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] a = Console.ReadLine().Split().Select(int.Parse).ToArray();
            int[] b = Console.ReadLine().Split().Select(int.Parse).ToArray();
           int  max = Math.Max(a.Length, b.Length);
            int [] c= new int [max];
            if(a.Length<b.Length)
            {
                for (int i = 0; i < max; i++)
                {
                    Array.Copy(a, a, b.Length);
                   // a[i] = a[0] + a[i];
                }
            }
            Console.WriteLine(string.Join(" ",a));
        }
    }
}
