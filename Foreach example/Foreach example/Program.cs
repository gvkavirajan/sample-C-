using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Foreach_example
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] pets = { "cat", "dog", "rabbit" };
            foreach (string value in pets)
            {
                Console.WriteLine(value);
                Console.ReadLine();
            }
        }
    }
}
