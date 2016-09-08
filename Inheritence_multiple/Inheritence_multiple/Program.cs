using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritence_multiple
{
    class Program
    {
        interface calc1
        {
            int add(int a, int b);
        }
        interface calc2
        {
            int sub(int x, int y);
        }
        class calculation : calc1
        {
            public int result1;
            public int add(int a, int b)
            {
                return result1 = a + b;
            }
            class calc2:calculation
            {
                public int result2;
                public int sub(int x, int y)
                {
                    return result2 = x - y;
                }
                static void Main(string[] args)
                {
                    calculation c = new calculation();
                    c.add(8, 2);
                    Console.WriteLine("addition:" + c.result1);
                    Console.ReadLine();
                }
            }
        }
    }
}