using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenricsExample
{
    public class TestClass<T>
    {
        T[] bj = new T[5];
        int value;
        //string words;

        public void Add(T num)
        {
            if (value < 5)
            {
                bj[value] = num;
            }
            value++;
        }
         
        
        public T this[int index]
        {
            get { return bj[index]; }
            set { bj[index] = value; }
        }
    }
        class Program
        {
            static void Main(string[] args)
            {
                TestClass<int> bj = new TestClass<int>();
                bj.Add(1);
                bj.Add(2);
                bj.Add(3);
                bj.Add(4);
                bj.Add(5);

                for (int i = 0; i < 5; i++)
                {
                    Console.WriteLine(bj[i]);

                }
                //Console.ReadLine();

                TestClass<string> strObj = new TestClass<string>();
                strObj.Add("Hello");
                strObj.Add("You have");
                strObj.Add("already ");
                strObj.Add("Completed the code to");
                strObj.Add("handling a String value");

                for (int i = 0; i < 5; i++)
                {
                    Console.WriteLine(strObj[i]);

                }

                Console.ReadLine();
           }
      }
 }   