using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace oops_Abstraction
{
    class Program
    {
        public abstract class university //base class
        {
            public abstract void btech();
            public abstract void mba();
        }
        public class autonomous : university //derived class
        {
            public override void btech()
            {
                Console.WriteLine("btech fee 1000");
            }
            public override void mba()
            {
                Console.WriteLine("mba fee 5000");
            }
        }
        static void Main(string[] args)
        {
            autonomous aus = new autonomous();
            aus.btech();
            aus.mba();
            Console.ReadLine();
        }
    }
}
