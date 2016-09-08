using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace structure_example2
{
    class Program
    {
        struct c
        {
            public int rollno;
            public string fname;
            public string lname;
        };

        static void Main(string[] args)
        {
            c empdetails;
            empdetails.rollno = 10;
            empdetails.fname = "martin";
            empdetails.lname = "joseph";
            Console.WriteLine(empdetails.fname+" "+empdetails.lname+" "+empdetails.rollno);
            Console.WriteLine("This is Struct method");
            Console.ReadLine();
        }

    }
}
