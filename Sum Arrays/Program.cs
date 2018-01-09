using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sum_Arrays
{
    class Program
    {
        static void Main(string[] args)
        {
           List<int> arr1 = Console.ReadLine().Split(' ').Select(int.Parse).ToList();
           List<int> arr2 = Console.ReadLine().Split(' ').Select(int.Parse).ToList();
        
           
            List<int> sum = new List<int>();
            int max = Math.Max(arr1.Count, arr2.Count);
           
            if (arr1.Count > arr2.Count)
            {
                for (int i = 0; i < max; i++)
                {
                  
                    arr2.Add(arr2[i]);
                }
            }
            else
                for (int i = 0; i < max; i++)
                {
                    arr1.Add(arr1[i]);

                }
            for (int i = 0; i < max; i++)
            {
                sum.Add(arr1[i] + arr2[i]);
            }
            Console.WriteLine(string.Join(" ", sum));
        }
    }
}
    
