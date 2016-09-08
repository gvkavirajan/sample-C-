using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApplication2
{
    class Program
    {
        abstract class birds  // abstract class cannot create an object
        {
            public abstract void fly();
            public void sound()
            {
                Console.WriteLine("birds Can sound");
            }
        }
    class parrot : birds
        {
            public override void fly()
                {
                    Console.WriteLine("birds can parrot");
                }
        }
        static void Main(string[] args)
            {
                parrot obj=new parrot ();
                obj.fly();
                obj.sound();
                Console.Read();
            }
    }
}
    

