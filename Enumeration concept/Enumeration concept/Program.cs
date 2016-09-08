using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Enumeration_concept
{
    class Program
    {
        enum importance
        {
            none, trival, critical, regular
        }
        static void Main(string[] args)
        {
            importance value = importance.critical;
            if(value==importance.regular)
            {
                Console.WriteLine("not true");
            }
            else if(value==importance.critical);
            {
                Console.WriteLine("critical");
            }
            Console.ReadLine();
        }
    }
}
