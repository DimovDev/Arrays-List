using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Reverse_an_Array_of_Strings
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] str = Console.ReadLine().Split(' ').ToArray();
            string[] rotatedstr = new string [str.Length];
        
        for (int i = 0; i<str.Length-1; i++)
			{
                rotatedstr[0] = str[str.Length-1];
                var lastElement = str[rotatedstr.Length - 1];
                rotatedstr[i] = lastElement;
            }
            Console.WriteLine(string.Join(" ", rotatedstr));
        }
    }
}
