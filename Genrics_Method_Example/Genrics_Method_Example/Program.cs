using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Genrics_Method_Example
{
    class Sample
    {
        public void method<Type>(string name, int id)
        {
            Console.WriteLine("{0}:{1}", name, id);
        }
    }
    public class Programm
    {
        static void Main(string[] args)
        {
            Sample o = new Sample();
            o.method<int>("Mani", 1094);
            o.method<string>("Sudar", 1095);
            o.method<double>("Gopi", 1093);
            o.method<char>("Sarath", 1098);
            o.method<bool>("Muthu", 1099);
            Console.ReadLine();
        }
    }
}
