using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace break_statment
{
    class Program
    {
        static void Main(string[] args)
        {
           for (int num=0;num<30;num++)
           {
               if(num==15)
                   break;  //Come's Out the loop
                  
            if (num%2==0)
                continue;   //Again starts the loop
            Console.WriteLine("{0}",num);
        }
                Console.ReadLine();
            }


        }
    }
