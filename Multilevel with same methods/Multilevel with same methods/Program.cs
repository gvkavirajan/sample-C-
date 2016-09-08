using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Multilevel_with_same_methods
{
    public class person
    {
        public string name = "Mani";
        public virtual void information()
        {
            Console.WriteLine("Name:{0}", name);
        }
    }
    public class student:person
    {
        public string Rno = "45";
        public override void information()
        {
            base.information();
            Console.WriteLine("Rno:{0}", Rno);
        }
    }
    public class character:student
    {
        public string address = "Banglore";
        public override void information()
        {
            base.information();
            Console.WriteLine("Address:{0}", address);
        }
    }
    class sample
    {
        static void Main(string[] args)
        {
            character c = new character();
            c.information();
            Console.ReadLine();
        }
    }
}
