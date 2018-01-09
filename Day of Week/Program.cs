using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day_of_Week
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] day = { "Monday", "Tuesday", "Wednesday", "Thursday", "Friday", "Saturday", "Sunday"};
            int n = int.Parse(Console.ReadLine());
            if (n > 7|| n<=0) { Console.WriteLine("Invalid Day!"); }
            else { Console.WriteLine(day[n-1]); }
        }
    }
}
