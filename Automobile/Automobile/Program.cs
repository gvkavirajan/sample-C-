using System;
using System.Collections.Generic;
using System.Linq;

using System.Threading.Tasks;
using System.Collections;

namespace Automobile
{

    public abstract class Automobile
        {
            public abstract void NumberOfSideMirrors();
            public abstract void NumberOfWheels();
            public abstract void NumberOfPassengers();
            public abstract void NumberOfGears();
        }
    class Car : Automobile
        {
            public int NumberOfSideMirrorss, NumberOfWheelss, NumberOfPassengerss, NumberOfGearss;
        
            public void display()
                {
                    ArrayList list1 = new ArrayList();
                    Console.WriteLine("\n Please Choose Your Car");
                    Console.WriteLine("= = = = = = = = = \n");
                    list1.Add("1.Manza");
                    list1.Add("2.Alto");
                    list1.Add("3.Swift");

            foreach (string i in list1)
                {
                    Console.WriteLine(i);
                }
                    Console.WriteLine("Enter your choice :");
                    int list = int.Parse(Console.ReadLine());

            switch (list)
                {
                    case 1:
                        Manza o = new Manza("8 Lakh","16km/Litre","Diesel");
                        break;
                    case 2:
                        Alto o1 = new Alto("8 Lakh", "16km/Litre", "Petrol");
                        break;
                    case 3:
                        Swift o2=new Swift("8 Lakh", "16km/Litre", "Petrol");
                        break;
                }
                }

        public Car()
            {

            }
        ~Car()
            {
                Console.WriteLine("Destructor Called");
            }

        public Car(int A, int B, int C, int D)
        {
            NumberOfSideMirrorss = A;
            NumberOfWheelss = B;
            NumberOfPassengerss = C;
            NumberOfGearss = D;
        }
        public override void NumberOfSideMirrors()
        {
            Console.WriteLine("Car NumberOfSideMirrors={0}", NumberOfSideMirrorss);
        }
        public override void NumberOfWheels()
        {
            Console.WriteLine("Car NumberOfWheels={0}", NumberOfWheelss);
        }
        public override void NumberOfPassengers()
        {
            Console.WriteLine("Car NumberOfPassengers={0}", NumberOfPassengerss);
        }
        public override void NumberOfGears()
        {
            Console.WriteLine("Car NumberOfGears={0}", NumberOfGearss);
        }
    }

    class Bike : Automobile
    {
        public int NumberOfWheels1, NumberOfSideMirrors1, NumberOfPassengers1, NumberOfGears1;

        public void display1()
        {
            ArrayList list2 = new ArrayList();
            Console.WriteLine("\nPlease Choose Your Bike");
            Console.WriteLine("= = = = = = = = = \n");
            list2.Add("1.Hero Honda");
            list2.Add("2.Apache");
            list2.Add("3.Splender");

            foreach (string s in list2)
            {
                Console.WriteLine(s);
            }
            Console.WriteLine("Enter your choice :");
            int list = int.Parse(Console.ReadLine());


            switch (list)
            {
                case 1:
                    HeroHonda o=new HeroHonda("60 Thousand","70km/Litre","Black");
                    break;
                case 2:
                    Apache o1=new Apache("80 Thousand","50km/Litre","yellow");
                    break;
                case 3:
                    splender o2=new splender("68 Thousand","75km/Litre","Red");
                    break;
            }
        }

        public Bike()
        {

        }
        ~Bike()
        {
            Console.WriteLine("Destructor called");
        }

        public Bike(int E, int F, int G, int H)
        {
            NumberOfSideMirrors1 = E;
            NumberOfWheels1 = F;
            NumberOfPassengers1 = G;
            NumberOfGears1 = H;
        }

        public override void NumberOfSideMirrors()
        {
            Console.WriteLine("Bike Side Mirrorss={0}", NumberOfSideMirrors1);
        }
        public override void NumberOfWheels()
        {
            Console.WriteLine("Bike NumberOfWheelss={0}", NumberOfWheels1);
        }
        public override void NumberOfPassengers()
        {
            Console.WriteLine("Bike NumberOfPassengerss={0}", NumberOfPassengers1);
        }
        public override void NumberOfGears()
        {
            Console.WriteLine("Bike NumberOfGearss={0}", NumberOfGears1);
        }
    }
  
        class Manza : Car
        {
            string Price, Mileage, Diesel;
            

           public Manza(string price,string mileage,string diesel)
            {

                Price = price;
                Mileage = mileage;
                Diesel = diesel;
                            
                Console.WriteLine("Manza Specification");
                Console.WriteLine("====");
                Console.WriteLine("Price:{0}",Price);
                Console.WriteLine("Mileage : {0}",Mileage);
                Console.WriteLine("Type : {0}",Diesel);
                
                Console.WriteLine("Do you want to exit : (Yes / No)");
              
             string choice = Console.ReadLine();

            if (choice == "Yes")
            {
                Environment.Exit(1);
            }

            if (choice == "No")
            {
                
                display();
            }
            Console.ReadLine();
        }
    }
      
        class Alto : Car
        {
            string Price, Mileage, Petrol;

            public Alto(string price,string mileage,string petrol)
            {
                Price=price;
                Mileage=mileage;
                Petrol=petrol;

                Console.WriteLine("Alto Specification");
                Console.WriteLine("====");
                Console.WriteLine("Price :{0}",Price);
                Console.WriteLine("Mileage : {0}",Mileage);
                Console.WriteLine("Type : Petrol",Petrol);
                Console.WriteLine("Do you want to exit : (Yes / No)");

                string choice = Console.ReadLine();

                if (choice == "Yes")
                {
                    Environment.Exit(1);
                }

                if (choice == "No")
                {

                    display();
                }
                Console.ReadLine();
            }
        }

        class Swift : Car
        {
            string Price, Mileage, Petrol;
            public Swift(string price,string mileage,string petrol)
            {
                Price = price;
                Mileage = mileage;
                Petrol = petrol;

                Console.WriteLine("Swift Specification");
                Console.WriteLine("====");
                Console.WriteLine("Price :{0}",Price);
                Console.WriteLine("Mileage : {0}",Mileage);
                Console.WriteLine("Type : {0}",Petrol);
                Console.WriteLine("Do you want to exit : (Yes / No)");

                string choice = Console.ReadLine();

                if (choice == "Yes")
                {
                    Environment.Exit(1);
                }

                if (choice == "No")
                {

                    display();
                }
                Console.ReadLine();
            }
        }


        class HeroHonda : Bike
        {
            string Price, Mileage, Color;
            public HeroHonda(string price,string mileage,string color)
            {
                Price = price;
                Mileage = mileage;
                Color = color;
                Console.WriteLine("Hero Honda Specification");
                Console.WriteLine("====");
                Console.WriteLine("Price :{0}",Price);
                Console.WriteLine("Mileage : {0}",Mileage);
                Console.WriteLine("Color : {0}",Color);

                Console.WriteLine("Do you want to exit : (Yes / No)");

                string choice = Console.ReadLine();

                if (choice == "Yes")
                {
                    Environment.Exit(1);
                }

                if (choice == "No")
                {

                    display1();
                }
                Console.ReadLine();
            }
        }

        class Apache : Bike
        {
            string Price, Mileage, Color;
            public Apache(string price,string mileage,string color)
            {
                Price = price;
                Mileage = mileage;
                Color = color;
                Console.WriteLine("Apache Specification");
                Console.WriteLine("====");
                Console.WriteLine("Price : {0}",Price);
                Console.WriteLine("Mileage : {0}",Mileage);
                Console.WriteLine("Color : {0}",Color);
                Console.WriteLine("Do you want to exit : (Yes / No)");

                string choice = Console.ReadLine();

                if (choice == "Yes")
                {
                    Environment.Exit(1);
                }

                if (choice == "No")
                {

                    display1();
                }
                Console.ReadLine();
            }
        }

        class splender : Bike
        {
            string Price, Mileage, Color;
            public splender(string price,string mileage,string color)
            {
                Price = price;
                Mileage = mileage;
                Color = color;

                Console.WriteLine("Splendar Specification");
                Console.WriteLine("====");
                Console.WriteLine("Price : {0}",Price);
                Console.WriteLine("Mileage : {0}",Mileage);
                Console.WriteLine("Color : {0}",Color);
                Console.WriteLine("Do you want to exit : (Yes / No)");

                string choice = Console.ReadLine();

                if (choice == "Yes")
                {
                    Environment.Exit(1);
                }

                if (choice == "No")
                {

                    display1();
                }
                Console.ReadLine();
            }
        }

        class Programm
        {
            static void Main(string[] args)
            {
                Console.WriteLine("Menu");
                Console.WriteLine("= = = = = =");
                Console.WriteLine("1. Car");
                Console.WriteLine("2. Bike");
                Console.WriteLine("3. Exit");
                Console.WriteLine("Enter Your Choice");
                int list = int.Parse(Console.ReadLine());
              

                switch (list)
                {
                    case 1:
                        Car o = new Car(2,4,5,5);
                        Console.WriteLine("Car Details");
                        Console.WriteLine("= = = = =");
                        o.NumberOfSideMirrors();
                        o.NumberOfWheels();
                        o.NumberOfPassengers();
                        o.NumberOfGears();
                        o.display();
                        break;

                    case 2:
                        Bike o1 = new Bike(1,2,2,4);
                        o1.NumberOfSideMirrors();
                        o1.NumberOfWheels();
                        o1.NumberOfPassengers();
                        o1.NumberOfGears();
                        o1.display1();
                        break;
                                  
                    case 3:
                        
                    default:
                        break;
             }
                
                
                Console.ReadLine();
         }
     }
}

