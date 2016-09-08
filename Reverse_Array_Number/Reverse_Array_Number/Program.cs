using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Reverse_Array_Number
{
    class Program
    {
        static void Main(string[] args)
        {
            int [] numbers = new int[5];
            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine("Number {0}=", i+1);
                numbers[i] = Convert.ToInt32(Console.ReadLine());
            }
                for (int i = 4; i >= 0; i--)
                Console.WriteLine("{0}", numbers[i]);
                Console.ReadLine();
        }
    }
}
