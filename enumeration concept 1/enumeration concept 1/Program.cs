using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace enumeration_concept_1
{
    class Program
    {
        enum workingdays
        {
            sun, mon, tue, wed, thu, fri, sat
        };


        static void Main(string[] args)
        {
            workingdays value = workingdays.mon;
            workingdays value1 = workingdays.tue;
            workingdays value2 = workingdays.wed;
            workingdays value3 = workingdays.thu;
            workingdays value4 = workingdays.fri;
           
            if (value == workingdays.sat)
            {
                Console.WriteLine("the day is:{0}",false);
            }
              
                   else if (value1 == workingdays.tue)
            {
                Console.WriteLine("the day is:{1}",true);
            }
            else if (value2 == workingdays.wed)
            {
                Console.WriteLine("the day is:{2}",true);
            }
            else if (value3 == workingdays.thu)
            {
                Console.WriteLine("the day is:{3}",true);
            }
            else if (value4 == workingdays.fri)
            {
                Console.WriteLine("the day is:{4}",true);
            }

            Console.ReadLine();
        }
    }
}
