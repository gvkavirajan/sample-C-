using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace Automobile_TaskNew
{
    class Program
    {
        public abstract class Vehicle
        {
            public abstract void Car();
            public abstract void Bike();
            public abstract void Exit();
        }
        public class TwoFourwheeler : Vehicle
        {
            public override void Car()
            {
                ArrayList list1 = new ArrayList();

                list1.Add("1.Manza");
                list1.Add("2.Alto");
                list1.Add("3.Swift");
                list1.Add("4.Scorpio");
                list1.Add("5.Inova");

                foreach (string i in list1)
                {
                    Console.WriteLine(i);
                }
                Console.WriteLine("Enter your choice :");
                int list = int.Parse(Console.ReadLine());

                switch (list)
                {
                    case 1:
                        Manza();
                        break;
                    case 2:
                        Alto();
                        break;
                    case 3:
                        Swift();
                        break;
                    case 4:
                        Scorpio();
                        break;
                    case 5:
                        Inova();
                        break;

                    default:
                        break;
                }
            }
            static void Manza()
            {
                Console.WriteLine("Manza Specification");
                Console.WriteLine("====");
                Console.WriteLine("Price: 7Lakh");
                Console.WriteLine("Mileage : 15km/Litre");
                Console.WriteLine("Type : Diesel");
                Console.WriteLine("Do you want to exit : (Yes / No)");

                string choice = Console.ReadLine();



                if (choice == "Yes")
                {
                    Environment.Exit(1);
                }

                if (choice == "No")
                {
                    TwoFourwheeler o = new TwoFourwheeler();
                    o.Car();
                }
                Console.ReadLine();
            }

            static void Alto()
            {
                Console.WriteLine("Alto Specification");
                Console.WriteLine("====");
                Console.WriteLine("Price : 5Lakh");
                Console.WriteLine("Mileage : 18km/Litre");
                Console.WriteLine("Type : Petrol");
                Console.WriteLine("Do you want to exit : (Yes / No)");

                string choice = Console.ReadLine();

                if (choice == "Yes")
                {
                    Environment.Exit(1);
                }

                if (choice == "No")
                {
                    TwoFourwheeler o = new TwoFourwheeler();
                    o.Car();
                }
                Console.ReadLine();
            }

            static void Swift()
            {
                Console.WriteLine("Swift Specification");
                Console.WriteLine("====");
                Console.WriteLine("Price : 6Lakh");
                Console.WriteLine("Mileage : 14km/Litre");
                Console.WriteLine("Type : Petrol");
                Console.WriteLine("Do you want to exit : (Yes / No)");

                string choice = Console.ReadLine();

                if (choice == "Yes")
                {
                    Environment.Exit(1);

                }

                if (choice == "No")
                {
                    TwoFourwheeler o = new TwoFourwheeler();
                    o.Car();
                }
                Console.ReadLine();
            }

            static void Scorpio()
            {
                Console.WriteLine("Scorpio Specification");
                Console.WriteLine("====");
                Console.WriteLine("Price : 14Lakh");
                Console.WriteLine("Mileage : 8km/Litre");
                Console.WriteLine("Type : Diesel");
                Console.WriteLine("Do you want to exit : (Yes / No)");

                string choice = Console.ReadLine();

                if (choice == "Yes")
                {
                    Environment.Exit(1);

                }

                if (choice == "No")
                {
                    TwoFourwheeler o = new TwoFourwheeler();
                    o.Car();
                }
                Console.ReadLine();
            }

            static void Inova()
            {
                Console.WriteLine("Inova Specification");
                Console.WriteLine("====");
                Console.WriteLine("Price : 14Lakh");
                Console.WriteLine("Mileage : 9km/Litre");
                Console.WriteLine("Type : Petrol");
                Console.WriteLine("Do you want to exit : (Yes / No)");

                string choice = Console.ReadLine();

                if (choice == "Yes")
                {
                    Environment.Exit(1);

                }

                if (choice == "No")
                {
                    TwoFourwheeler o = new TwoFourwheeler();
                    o.Car();
                }
                Console.ReadLine();
            }

            public override void Bike()
            {
               
            ArrayList list2 = new ArrayList();
            list2.Add("1.Hero Honda");
            list2.Add("2.Apache");
            list2.Add("3.Splender");
            list2.Add("4.Pulsar");
            list2.Add("5.Activa");

            foreach (string s in list2)
            {
                Console.WriteLine(s);
            }
            Console.WriteLine("Enter your choice :");
            int list = int.Parse(Console.ReadLine());

            
            switch (list)
            {
                case 1:
                    HeroHonda();
                    break;
                case 2:
                    Apache();
                    break;
                case 3:
                    Splender();
                    break;
                case 4:
                    Pulsar();
                    break;
                case 5:
                    Activa();
                    break;

                default:
                    break;
            }
        }

        static void HeroHonda()
        {
            Console.WriteLine("Hero Honda Specification");
            Console.WriteLine("====");
            Console.WriteLine("Price : 67 Thousand");
            Console.WriteLine("Mileage : 70km/Litre");
            Console.WriteLine("Color : Black");

            Console.WriteLine("Do you want to exit : (Yes / No)");

            string choice = Console.ReadLine();

            if (choice == "Yes")
            {
                Environment.Exit(1);

            }

            if (choice == "No")
            {
               TwoFourwheeler o1=new TwoFourwheeler();
                o1.Bike();
            }
            Console.ReadLine();
        }
        static void Apache()
        {
            Console.WriteLine("Apache Specification");
            Console.WriteLine("====");
            Console.WriteLine("Price : 95 Thousand");
            Console.WriteLine("Mileage : 40km/Litre");
            Console.WriteLine("Color : Yellow");

            Console.WriteLine("Do you want to exit : (Yes / No)");

            string choice = Console.ReadLine();

            if (choice == "Yes")
            {
                Environment.Exit(1);

            }

            if (choice == "No")
            {
                TwoFourwheeler o1=new TwoFourwheeler();
                o1.Bike();
            }
            Console.ReadLine();
        }
        static void Splender()
        {
            Console.WriteLine("Splendar Specification");
            Console.WriteLine("====");
            Console.WriteLine("Price : 70 Thousand");
            Console.WriteLine("Mileage : 75km/Litre");
            Console.WriteLine("Color : Red");
            Console.WriteLine("Do you want to exit : (Yes / No)");

            string choice = Console.ReadLine();

            if (choice == "Yes")
            {
                Environment.Exit(1);
                    
            }

            if (choice == "No")
            {
                TwoFourwheeler o1=new TwoFourwheeler();
                o1.Bike();
            }
            Console.ReadLine();
        }
        static void Pulsar()
        {
            Console.WriteLine("Pulsar Specification");
            Console.WriteLine("====");
            Console.WriteLine("Price :  1 Lakh");
            Console.WriteLine("Mileage : 30km/Litre");
            Console.WriteLine("Color : Black");
            Console.WriteLine("Do you want to exit : (Yes / No)");

            string choice = Console.ReadLine();

            if (choice == "Yes")
            {
                Environment.Exit(1);

            }

            if (choice == "No")
            {
                TwoFourwheeler o1=new TwoFourwheeler();
                o1.Bike();
            }
            Console.ReadLine();
        }
        static void Activa()
        {
            Console.WriteLine("Activa Specification");
            Console.WriteLine("====");
            Console.WriteLine("Price : 65 Thousand");
            Console.WriteLine("Mileage : 50km/Litre");
            Console.WriteLine("Color : Black");
            Console.WriteLine("Do you want to exit : (Yes / No)");

            string choice = Console.ReadLine();

            if (choice == "Yes")
            {
                Environment.Exit(1);

            }

            if (choice == "No")
            {
                TwoFourwheeler o1=new TwoFourwheeler();
                o1.Bike();
            }
            Console.ReadLine();
        }
            
            public override void Exit()
            {
                Environment.Exit(1);
            }
       
          
            static void Main(string[] args)
            {
                Console.WriteLine("Menu");

                Console.WriteLine("====");

                Console.WriteLine("1.Car");

                Console.WriteLine("2.Bike");

                Console.WriteLine("3.Exit");

                Console.WriteLine("Enter your choice");

                int list = int.Parse(Console.ReadLine());
                switch (list)
                {
                    case 1:
                        TwoFourwheeler o = new TwoFourwheeler();
                        o.Car();
                        break;

                    case 2:
                        TwoFourwheeler o1 = new TwoFourwheeler();
                        o1.Bike();
                        break;

                    case 3:
                        TwoFourwheeler o2 = new TwoFourwheeler();
                        o2.Exit();
                        break;

                    default:
                        break;
                }
                Console.ReadLine();
            }
            ~TwoFourwheeler()
            {
                Console.WriteLine("Object Destroyed");
                Console.Read();

            }
        }
    }
}
