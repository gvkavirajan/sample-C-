using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace polymorphism_methodoverloading
{
    class Class1
    {

        public int Sum(int A, int B)
        {
            return A + B;
        }

        public float Sum(int A, float B)
        {
            return A + B;
        }
    }

    class Class2 : Class1
    {
        public int Sum(int A, int B, int C)
        {
            return A + B + C;

        }
    }

    class MainClass
    {
        static void Main()
        {

            Class2 obj = new Class2();

            Console.WriteLine(obj.Sum(10, 20));

            Console.WriteLine(obj.Sum(10, 15.70f));

            Console.WriteLine(obj.Sum(10, 20, 30));

            Console.Read();
        }

    }
}

