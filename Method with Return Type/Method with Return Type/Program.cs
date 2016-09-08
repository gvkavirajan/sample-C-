using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Method_with_Return_Type
{
    class Program
    {
        public static int mul(int i, int j)
        {
            int k = i * j;
            return k;
        }
        static void Main(string[] args)
        {
            Console.WriteLine(mul(2, 3));
            Console.ReadLine();
        }
    }
}
