using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
namespace structure_example
{
    class Program
    {
        struct simple
        {
            public int position;
            public int exists;
            public int lastvalue;
        }


           static void Main(string[] args)
            {
               simple s;
               s.position = 1;
               s.exists = 2;
               s.lastvalue = 5;
               Console.WriteLine(s.position);
               Console.WriteLine(s.exists);
               Console.ReadLine();
            }
             //structure is faster compare to class
        //eg:class=8 ints-2418ms
        //eg:struct=8 ints -936ms
    }
}