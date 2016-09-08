using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace property_GetSet
{
    class Program
    {
        int number;
        public int number1
        {
            get
            {
                return this.number;
            }
            set
            {
                this.number = value;
            }
        }
        static void Main(string[] args)
        {
            Program p = new Program();
            p.number = 5;//set the value
            Console.WriteLine(p.number);//get the value
            Console.ReadLine();
        }
    }
}
