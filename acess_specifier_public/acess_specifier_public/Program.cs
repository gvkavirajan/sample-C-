using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace acess_specifier_public
{
    class car
    {
        public string carcolor;
        public void carname()
        {
            Console.WriteLine("\nMy name is " + carcolor);
        }
    }
    class program
    {
        static void Main(string[] args)
        {
            car mycar = new car();
            Console.WriteLine("Enter the car color:");
            mycar.carcolor = Console.ReadLine();
            mycar.carname();
            Console.ReadLine();
        }
    }
}
