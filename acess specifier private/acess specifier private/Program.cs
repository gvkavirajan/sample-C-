using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace acess_specifier_private
{
    class car
    {
        private  string carcolor;//private,protected does not work because outside the class(protected acsess derived class and base class)
        public void carname()
        {
            Console.WriteLine("\n My carcolor is " + carcolor);
        }
    }
    class programm
    {
        static void Main(string[] args)
        {
            car mycar = new car();
            Console.WriteLine("Enter Your color:");
            mycar.carcolor= Console.ReadLine();        
            mycar.carname();
            Console.ReadLine();
        }
    }
}
