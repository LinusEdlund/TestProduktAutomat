using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TestProduktAutomat.App;
using TestProduktAutomat.Domain.Abstrakt;
using TestProduktAutomat.Domain.Entities;
using TestProduktAutomat.Domain.Enums;
using TestProduktAutomat.Domain.Interface;
using TestProduktAutomat.Domain.Plånbok;

namespace TestProduktAutomat.UI
{
    public class AppScreen :  IItems, IPlånbok
    {
        
        
        public void InitializeDataMonye()
        {
            for (int i = 0; i < 10; i++)
            {
                new Plånboken(1, 5, 10, 20, 50, 100);
            }
        }

        public void InitializeDataDrinks()
        {
            Drink.DrinkList = new List<Drink>
            {
                new Drink(1, "Monster",10,"",2, false),
                new Drink(2, "Fanta",20,"",2, false),
                new Drink(3, "Redbull",5,"",2, false)
            };
            
        }

        public void InitializeDataKläder()
        {
            Kläder.KläderList = new List<Kläder>
            {
                new Kläder(1, "t-shirt", 200, "", "tyg", false),
                new Kläder(2, "Jeans", 500, "", "tyg", false ),
                new Kläder(3, "boomul-tröja", 1000, "", "boomul", false)
            };
            
        }

        public void InitializeDataMat()
        {
            Mat.MatList = new List<Mat>
            {
                new Mat(1, "Korv",10,"", false),
                new Mat(2, "Kött",100,"", false),
                new Mat(3, "skinka",20,"", false)

            };
            
        }

        public void Run()
        {
            Welcome();
            while (true)
            {
                DisplayMenu();
                ProcessMenuoption();


            }

        }

        public void RunOnlyMenu()
        {
            while (true)
            {
                DisplayMenu();
                ProcessMenuoption();


            }
        }


        internal static void Welcome()
        {
            Console.Clear();
            Console.Title = "Produkt-Automat";
            Console.ForegroundColor = ConsoleColor.White;

            Console.WriteLine("\n-------------------------------Welcome to Produkt-Automat-------------------------------\n");
            Console.WriteLine("");
            Utility.PressEnterToContinue();


        }

        internal static void DisplayMenu()
        {
            Console.Clear();
            Console.WriteLine("----------Category----------");
            Console.WriteLine(":                          :");
            Console.WriteLine("1. Drinks                  :");
            Console.WriteLine("2. Kläder                  :");
            Console.WriteLine("3. Mat                     :");
            Console.WriteLine("---------------------------:");
            Console.WriteLine("4. Plånbok                 :");
            Console.WriteLine("5. List                    :");
            Console.WriteLine("6. Exit                    :");
        }

        internal static void DisplayOption()
        {

            Console.WriteLine("----------Options----------");
            Console.WriteLine(":                         :");
            Console.WriteLine("1. Purchase               :");
            Console.WriteLine("2. Description            :");
            Console.WriteLine("3. Use                    :");
            Console.WriteLine("--------------------------:");
            Console.WriteLine("4. Plånbok                :");
            Console.WriteLine("5. List                   :");
            Console.WriteLine("6. Back                   :");
        }

        internal static void ExitOut()
        {
            Console.Clear();
            Console.WriteLine("Thank you for using...");

            //here is monye
            //Kanske också transations

        }

        internal void ProcessMenuoption()
        {
            switch (Validator.Convert<int>("an option"))
            {
                case (int)Menu.ViewDrinks:

                    while (true)
                    {
                        ViewDrinkMenu();
                        DisplayOption();
                        ProcessOptionDrinks();
                    }


                case (int)Menu.ViewKläder:

                    while (true)
                    {
                        ViewKläderMenu();
                        DisplayOption();
                        ProcessOptionKläder();
                    }

                case (int)Menu.ViewMat:
                    while (true)
                    {
                        ViewMatMenu();
                        DisplayOption();
                        ProcessOptionMat();

                    }

                case (int)Menu.ViewPlånbok:

                    while (true)
                    {
                        
                        AddMonye();

                    }
                    
                    


                    break;

                case (int)Menu.ViewList:
                        ViewShopingList();
                        Utility.PressEnterToContinue();
                        break;                   

                case (int)Menu.Exiting:

                    ExitOut();
                    Utility.PrintMessage("You have successfullt exit the app.", true);

                    Run();
                    break;

                default:
                    Utility.PrintMessage("Invalid Option.", false);
                    break;
            }

        }
        //----------------------------------------------------------------------------------------------------------------------------------------
        //fösök minska kod!!!
        internal void ProcessOptionDrinks()
        {
            switch (Validator.Convert<int>("an option"))
            {
                case (int)Option.BuyProdukt:
                    WhoBuyDrinks();


                    break;

                case (int)Option.Description:

                    break;

                case (int)Option.Use:

                    break;

                case (int)Option.ViewPlånbok:

                    while (true)
                    {
                        
                        AddMonye();

                    }

                    break;

                case (int)Option.ViewList:
                    ViewShopingList();
                    Utility.PressEnterToContinue();
                    break;

                case (int)Option.Back:
                    RunOnlyMenu();

                    break;

                default:
                    Utility.PrintMessage("Invalid Option.", false);
                    break;
            }
        }

        internal void ProcessOptionKläder()
        {
            switch (Validator.Convert<int>("an option"))
            {
                case (int)Option.BuyProdukt:
                    WhoBuyKläder();


                    break;

                case (int)Option.Description:

                    break;

                case (int)Option.Use:

                    break;

                case (int)Option.ViewPlånbok:

                    while (true)
                    {
                        
                        AddMonye();

                    }

                    break;

                case (int)Option.ViewList:
                    ViewShopingList();
                    Utility.PressEnterToContinue();

                    break;

                case (int)Option.Back:
                    RunOnlyMenu();

                    break;

                default:
                    Utility.PrintMessage("Invalid Option.", false);
                    break;
            }
        }

        internal void ProcessOptionMat()
        {
            switch (Validator.Convert<int>("an option"))
            {
                case (int)Option.BuyProdukt:
                    WhoBuyMat();

                    break;

                case (int)Option.Description:

                    break;

                case (int)Option.Use:

                    break;

                case (int)Option.ViewPlånbok:

                    while (true)
                    {
                        
                        AddMonye();

                    }

                    break;

                case (int)Option.ViewList:
                    ViewShopingList();
                    Utility.PressEnterToContinue();

                    break;

                case (int)Option.Back:
                    RunOnlyMenu();

                    break;

                default:
                    Utility.PrintMessage("Invalid Option.", false);
                    break;
            }
        }

        //-------------------------------------------------------------------------------------------------------------------------------------
       
        public void ViewShopingList()
        {
            Console.WriteLine("");
            foreach (var item in Iteam.shopingLists)
            {
                Console.WriteLine(item.DisplayList);
            }
        }



        public void ViewDrinkMenu()
        {

            Console.Clear();

            foreach (var item in Drink.DrinkList)
            {
                if (item.Sold == false)
                {
                    Console.WriteLine(item.Display);
                }


            }





        }

        public void ViewKläderMenu()
        {

            Console.Clear();


            foreach (var item in Kläder.KläderList)
            {
                if (item.Sold == false)
                {
                    Console.WriteLine(item.Display);
                }

            }

        }

        public void ViewMatMenu()
        {

            Console.Clear();
            foreach (var item in Mat.MatList)
            {
                if (item.Sold == false)
                {
                    Console.WriteLine(item.Display);
                }

            }



        }


        //----------------------------------------------------------------------------------------------------------------------------------------
        //tänk på hur du kan göra mindre kod
        //här använder du buy 
        public void WhoBuyDrinks()
        {
            Console.WriteLine("What item do you want from the list on top?");
            int number = Validator.Convert<int>("the Id");

            
            for (int i = 0; i <= Drink.DrinkList.Count; i++)
            {

                if (number == i)
                {
                    i--;
                    Drink.DrinkList[i].Buy();
                    break;
                }
            }
        }


        public void WhoBuyKläder()
        {
            Console.WriteLine("What item do you want from the list on top?");
            int number = Validator.Convert<int>("the Id");

            for (int i = 0; i <= Kläder.KläderList.Count; i++)
            {

                if (number == i)
                {
                    i--;
                    Kläder.KläderList[i].Buy();
                    break;
                }
            }
        }


        public void WhoBuyMat()
        {
            Console.WriteLine("What item do you want from the list on top?");
            int number = Validator.Convert<int>("the Id");

            for (int i = 0; i <= Mat.MatList.Count; i++)
            {

                if (number == i)
                {
                    i--;
                    Mat.MatList[i].Buy();
                    
                    break;
                }
            }


        }


        //--------------------------------------------------------------------------------------------------------------------------------------------

        public void AddMonye()
        {

            int selectedAmount = Plånboken.Amount();

            if (selectedAmount == -1)
            {
                AddMonye();
                return;
            }
            else if (selectedAmount == 0)
            {
                RunOnlyMenu();
                return;
            }
            else
            {
                
                Console.WriteLine("Checking so you inserted the correct amount");
                Utility.PrintDoAnimation();
                Utility.PrintMessage($"\n\nYou have succefully inserted {selectedAmount}kr to your account");
            }
            
            
            
            
            

        }
        















    }
}
