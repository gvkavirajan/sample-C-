using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Factorial_Example
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("It gives Factorial output");
            Console.WriteLine("Enter Your Number");
            int number = Int32.Parse(Console.ReadLine());
            int fact = 1;
            for (int i = number; i >= 2; i--)
            {
                fact = fact*i;
                
            }
            Console.WriteLine("\n The factorial of {0} is {1}.\n\n",number,fact);
            Console.ReadLine();
        }
  

    }
}
