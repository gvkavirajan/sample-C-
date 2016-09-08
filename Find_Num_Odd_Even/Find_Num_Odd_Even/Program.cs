using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Find_Num_Odd_Even
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Check The Number is an ODD or EVEN");
            Console.WriteLine("Enter Your Number");
            int num=Int16.Parse(Console.ReadLine());
            if ((num % 2) == 0)
            {
                Console.WriteLine("This is an Even Number");
            }
            else
            {
                Console.WriteLine("This is an Odd Number");
            }
            Console.ReadLine();
        }
    }
}
