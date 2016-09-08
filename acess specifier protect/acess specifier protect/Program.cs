using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace acess_specifier_protect
{
    class a
    {
        protected string carname="manza";
        public int carnumber=1234;
        private string carcolor="blue";
    }
    class b:a
    {
        public void information()
        {
            Console.WriteLine(this.carname);
            Console.WriteLine(this.carnumber);
            //Console.WriteLine(this.carcolor); //error occured because private access only inside of the class
        }
            static void Main(string[] args)
        {
            b derived = new b();
            derived.information();
            Console.ReadLine();
        }
    }
}
