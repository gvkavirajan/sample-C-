using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dictionary
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, int> d = new Dictionary<string, int>();
            d.Add("C#", 2);
            d.Add("Dotnet", 5);
            d.Add("Java", 3);
            d.Add("Php", 6);
            d.Remove("c#");
            if (d.ContainsValue(5))
            {
                Console.WriteLine(true);

                if (d.ContainsKey("Dotnet"))
                {
                    int value = d["C#"];
                    Console.WriteLine(value);
                }
                if (!d.ContainsKey("Sap"))
                {
                    Console.WriteLine(false);
                }
                    Console.ReadLine();
            }
        }
    }
}
