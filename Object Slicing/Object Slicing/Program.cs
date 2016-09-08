using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Object_Slicing
{
    class Base
    {
        public int i;
    }
    class Derived:Base
    {
        public int j;
    }
    class main
    {
        static void Main(string[] args)
        {
            Base objbase = new Base();
            Derived objderived = new Derived();
            objbase = objderived;
            //Here  objderived(derived_Object) contains both i & j But objbase contains only i 
            Console.ReadLine();
        }
    }
}
