using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SelectDog_Task
{
    class Program
    {
        enum Dogs
        {
            Max,
            Baily,
            Buddy,
            Molly,
            Maggie,
            Daisy,
            Bella,
            Jake,
            Rocky,
            Lucy,
        }

        public void Max()
        {
            Console.WriteLine(" Your dog's name will be Max ");
            Console.WriteLine("Do You Want To Exit:(Yes / No)");
            string choice = Console.ReadLine();
            if (choice == "Yes")
            {
                Environment.Exit(1);
            }
            if (choice == "No")
            {
                select_Dog();
            }
        }
        public void Baily()
        {
            Console.WriteLine(" Your dog's name will be Baily ");
            Console.WriteLine("Do You Want To Exit:(Yes / No)");
            string choice = Console.ReadLine();
            if (choice == "Yes")
            {
                Environment.Exit(1);
            }
            if (choice == "No")
            {
                select_Dog();
            }
        }

        public void Buddy()
        {
            Console.WriteLine(" Your dog's name will be Buddy ");
            Console.WriteLine("Do You Want To Exit:(Yes / No)");
            string choice = Console.ReadLine();
            if (choice == "Yes")
            {
                Environment.Exit(1);
            }
            if (choice == "No")
            {
                select_Dog();
            }
        }

        public void Molly()
        {
            Console.WriteLine(" Your dog's name will be Molly ");
            Console.WriteLine("Do You Want To Exit:(Yes / No)");
            string choice = Console.ReadLine();
            if (choice == "Yes")
            {
                Environment.Exit(1);
            }
            if (choice == "No")
            {
                select_Dog();
            }
        }

        public void Maggie()
        {
            Console.WriteLine(" Your dog's name will be Maggie ");
            Console.WriteLine("Do You Want To Exit:(Yes / No)");
            string choice = Console.ReadLine();
            if (choice == "Yes")
            {
                Environment.Exit(1);
            }
            if (choice == "No")
            {
                select_Dog();
            }
        }

        public void Daisy()
        {
            Console.WriteLine(" Your dog's name will be Daisy ");
            Console.WriteLine("Do You Want To Exit:(Yes / No)");
            string choice = Console.ReadLine();
            if (choice == "Yes")
            {
                Environment.Exit(1);
            }
            if (choice == "No")
            {
                select_Dog();
            }
        }


        public void Bella()
        {
            Console.WriteLine(" Your dog's name will be Bella ");
            Console.WriteLine("Do You Want To Exit:(Yes / No)");
            string choice = Console.ReadLine();
            if (choice == "Yes")
            {
                Environment.Exit(1);
            }
            if (choice == "No")
            {
                select_Dog();
            }
        }

        public void Jake()
        {
            Console.WriteLine(" Your dog's name will be Jake ");
            Console.WriteLine("Do You Want To Exit:(Yes / No)");
            string choice = Console.ReadLine();
            if (choice == "Yes")
            {
                Environment.Exit(1);
            }
            if (choice == "No")
            {
                select_Dog();
            }
        }

        public void Rocky()
        {
            Console.WriteLine(" Your dog's name will be Rocky ");
            Console.WriteLine("Do You Want To Exit:(Yes / No)");
            string choice = Console.ReadLine();
            if (choice == "Yes")
            {
                Environment.Exit(1);
            }
            if (choice == "No")
            {
                select_Dog();
            }
        }

        public void Lucy()
        {
            Console.WriteLine(" Your dog's name will be Lucy ");
            Console.WriteLine("Do You Want To Exit:(Yes / No)");
            string choice = Console.ReadLine();
            if (choice == "Yes")
            {
                Environment.Exit(1);
            }
            if (choice == "No")
            {
                select_Dog();
            }
        }

        static void Main(string[] args)
        {
            Program main = new Program();
            main.select_Dog();

            /* Use Above Enumeration Concept
             
             Dogs names = Dogs.Max;
            if (names == Dogs.Max)
            {
                Console.WriteLine("Correct");
            }
            else if (names != Dogs.Max)
            {
                Console.WriteLine("Not Correct");
            }*/
        }
            public void select_Dog()
            {
            Console.WriteLine("List Of Available Dogs:\n");
            Console.WriteLine("1 - Max");
            Console.WriteLine("2 - Baily");
            Console.WriteLine("3 - Buddy");
            Console.WriteLine("4 - Molly");
            Console.WriteLine("5 - Maggie");
            Console.WriteLine("6 - Daisy");
            Console.WriteLine("7 - Bella");
            Console.WriteLine("8 - Jake");
            Console.WriteLine("9 - Rocky");
            Console.WriteLine("10 - Lucy\n");
            Console.WriteLine("Enter Your Choice:");
            int list = int.Parse(Console.ReadLine());

            switch(list)
            {
                case 1:
                Program o=new Program();
                o.Max();
                break;

                case 2:
                Program o1 = new Program();
                o1.Baily();
                break;

                case 3:
                Program o2 = new Program();
                o2.Buddy();
                break;

                case 4:
                Program o3 = new Program();
                o3.Molly();
                break;

                case 5:
                Program o4 = new Program();
                o4.Maggie();
                break;

                case 6:
                Program o5 = new Program();
                o5.Daisy();
                break;

                case 7:
                Program o6 = new Program();
                o6.Bella();
                break;

                case 8:
                Program o7 = new Program();
                o7.Jake();
                break;

                case 9:
                Program o8 = new Program();
                o8.Rocky();
                break;

                case 10:
                Program o9 = new Program();
                o9.Lucy();
                break;
            }
                Console.ReadLine();
        }
    }
 }

