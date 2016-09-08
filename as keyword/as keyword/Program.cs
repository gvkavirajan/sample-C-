using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace as_keyword
{
    class Program
    {
        static void Main()
        {
                string variable1 = "Cat";
                object variable2 = variable1;  // object => Ultimate Base class for the All classes in .net ramework

                string variable3 = variable2 as string;
                if (variable3 != null)
                    {
                        Console.WriteLine("I Have a Cat");
                    }

                StringBuilder variable4 = variable2 as StringBuilder;
                if (variable4 != null)
                    {
                        Console.WriteLine("Have StringBuilder variable");
                    }
                Console.ReadLine();
        }
     }
 }

