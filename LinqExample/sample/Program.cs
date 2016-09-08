using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sample
{
    class Program
    {
        public void linq() 
        {
            List<string> CustomerName = new List<string>();
            CustomerName.Add("Mani");
            CustomerName.Add("Muthu");
            CustomerName.Add("Kumar");
            CustomerName.Add("Arun");
            CustomerName.Add("Elavarasan");
            CustomerName.Add("Bala");
            CustomerName.Add("Sundhar");
            CustomerName.Add("Xavier");
            CustomerName.Add("Arun");
            CustomerName.Add("Muthu");
            CustomerName.Add("Kumar");
            CustomerName.Add("Bala");
            CustomerName.Add("Vignesh");
            CustomerName.Add("Selva");

            
            //union

            int [] numberA = {0,2,4,6,8};
            int[] numberB = { 1, 3, 5, 7, 9 };

            var UniqueNumbers =
                              numberA.Union(numberB);
            Console.WriteLine("unique values in Both A and B:");

            foreach (var n in UniqueNumbers)
            {
                Console.WriteLine(n);
            }

            //order by

            var orderNames =
                              from o in CustomerName
                              orderby o
                              select o;
            Console.WriteLine("Sorted List Of Names:");
            foreach (var p in orderNames)
            {
                Console.WriteLine(p);
                
            }

            //Group by

            var GroupNames =
                            from g in CustomerName
                            orderby g
                            group g by g[0] into C
                            select new { Firstletter = C.Key, Words = C };
            foreach (var C in GroupNames)
            {
                Console.WriteLine("\nNames that start with the letter '{0}':", C.Firstletter);
                foreach (var g in C.Words)
                {
                    Console.WriteLine(g);
                }
            }

            //distinct

            var CategoryNames =
                                 (from n in CustomerName
                                 select n)
                                .Distinct();
            Console.WriteLine("\nCustomerNames:");
            foreach (var a in CategoryNames)
            {
                Console.WriteLine(a);
            }
                            

            Console.ReadLine();
        }

        static void Main(string[] args)
        {
           Program p = new Program();
            p.linq();
            //p.linq1();
        }
    }
}

          

