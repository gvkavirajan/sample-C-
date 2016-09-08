using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace oops_ClassObject
{
    class car     //create class
    { 
        public int numberofdoor;  //fields
        static void Main(string[] args)
        {
            car mycar = new car();  //mycar is an created object
            mycar.numberofdoor = 4;
            Console.WriteLine(mycar.numberofdoor);
            Console.ReadLine();
        }
    }
}
