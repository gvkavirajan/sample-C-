using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApplication1
{
    class hello
    {
        public abstract class talk
        {
            public abstract void speak();
        }
        public class sayhello : talk
        {
            public override void speak()
            {
                Console.WriteLine("hello");
                Console.ReadLine();
            }

            static void Main(string[] args)
            {
                sayhello hello = new sayhello();
                hello.speak();
            }
        }
    }
}