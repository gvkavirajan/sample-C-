using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace List_Examples
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> list = new List<int>();
            list.Add(2);
            list.Add(3);
            list.Add(5);
            list.Add(7);

            //foreach (int value in list)
            //{
            //    Console.WriteLine(value);
                
            //}
            for (int i = 0; i < list.Count; i++)
            {
                Console.WriteLine(list[i]);//2

                list.Clear();
                Console.WriteLine(list.Count);//0
            }
            Console.ReadLine();
        }
    }
}
