using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace polymorphism_methodoverriding
{
    class Program
    {
        //Same Method name Same Parameter called overriding

        public class Base
        {
          public virtual void sample1()
            {
                Console.WriteLine("Base class");
            }
        }
        public class Derived : Base
        {
            public override void sample1()
            {
                Console.WriteLine("Derived Class");
            }
            static void Main(string[] args)
            {
                Derived d = new Derived();
                d.sample1();
                Base b = new Base();
                b.sample1();
                Console.ReadLine();
            }
        }
    }
}