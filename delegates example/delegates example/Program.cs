using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

public delegate int numberchanger(int n);

namespace delegates_example
{
    class testdelegate
    {
        static int num = 10;
        public static int addnum(int p)
        {
            num += p;
            return num;
        }
        public static int mulnum(int q)
        {
            num *= q;
            return num;
        }
        public static int getnum()
        {
            return num;
        }


        static void Main(string[] args)
        {
            numberchanger nc1 = new numberchanger(addnum);
            numberchanger nc2 = new numberchanger(mulnum);
            nc1(25);
            Console.WriteLine("value of num:{0}", getnum());
            nc2(5);
            Console.WriteLine("value of num:{0}", getnum());
            Console.ReadLine();
        }
    }
}

       //Another  Delegate Example

// Declaration
//public delegate void SimpleDelegate();

//class TestDelegate
//{
//    public static void MyFunc()
//    {
//        Console.WriteLine("I was called by delegate ...");
//    }

//    public static void Main()
//    {
//        // Instantiation
//        SimpleDelegate simpleDelegate = new SimpleDelegate(MyFunc);

//        // Invocation
//        simpleDelegate();
//        Console.ReadLine();
//    }
//}
//}