using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Call_by_Value_Reference
{
    class Program
    {
        public static void increment(int a)
        {
            a=a+2;
            Console.WriteLine("inside the increment method=" + a.ToString());//12
            a=++a;
            Console.WriteLine("inside the increment method=" + a.ToString());//13
        }
        public static void decrement(ref int a)//use ref, affect the original value
        {
            a=a-2;
            Console.WriteLine("inside the  decrement method=" + a.ToString());//8
            a=--a;
             Console.WriteLine("inside the  decrement method="+a.ToString());//7
        }

        static void Main(string[] args)
        {
            int b = 10;
            Console.WriteLine("Before pass the increment method=" + b.ToString());//10
            increment(b);
            Console.WriteLine("After pass the increment method=" + b.ToString());//10
            Console.WriteLine("Before pass the decrement method=" + b.ToString());//10
            decrement(ref b);
            Console.WriteLine("After pass the decrement method=" + b.ToString());//7
            Console.ReadLine();
        }
    }
}