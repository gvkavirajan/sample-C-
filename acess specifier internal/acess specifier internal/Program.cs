using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace acess_specifier_internal
{
    class car
    {
        private string carcolor;//since the variable is private, it cannot be accessed outside the class defination.
        internal void horon()
        {
            Console.WriteLine("Beep! Beep!");
        }
    }
    class Bike
    {
        internal string bikecolor;//// since the variable is internal, it can be accessed outside the class defination.
    }
    class result
    {
        static void Main(string[] args)
        {
            car ford = new car();
            Bike honda = new Bike();
            //Ford.CarColor = "red"; //Error! cannot access private members.
            honda.bikecolor = "Blue";
            ford.horon(); // Displays BEEP BEEP!
            Console.ReadLine();
        }
    }
}
