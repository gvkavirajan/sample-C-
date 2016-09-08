using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace const_keyword_example
{
    class Program
    {
        const string _html = ".html";
    
    
        static void Main(string[] args)
        {
            Console.WriteLine(_html);
            Console.WriteLine(Program._html);
 
            const string txt = ".txt";
            Console.WriteLine(txt);
            Console.ReadLine();
        }
        
    }
}
