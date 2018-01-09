using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sum_Array_Elements
{
    class Program
    {
        static void Main(string[] args)
        {


            {
                int n = int.Parse(Console.ReadLine());
                int[] number = new int[n];
                int Sum = 0;
                int newsum = 0;
                //rotatedArrey = new string[array.Length];
                for (int i = 0; i < number.Length; i++)

                {
                    number[i] = int.Parse(Console.ReadLine());
                    Sum += number[i];
                   
                }
                Console.WriteLine(Sum);
            }
               
        }
    }
}


    