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
        
        //-----------------------------------------------------------------------------------------------------------------
        //Det här är all data som matas in i programet
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
                new Drink(1, "Monster",10,"Monster är en energidryck", false),
                new Drink(2, "Fanta",20,"Fanta är en läsk", false),
                new Drink(3, "Redbull",5,"Redbull är en energidryck", false)
            };
            
        }

        public void InitializeDataKläder()
        {
            Kläder.KläderList = new List<Kläder>
            {
                new Kläder(1, "t-shirt", 200, "Är en tröja med små armar", "tyg", false),
                new Kläder(2, "Jeans", 500, "Ett par byxor", "tyg", false ),
                new Kläder(3, "bomull tröja", 1000, "Är en lång armad tröja som är gjort av bomull ", "bomull", false)
            };
            
        }

        public void InitializeDataMat()
        {
            Mat.MatList = new List<Mat>
            {
                new Mat(1, "Korv",10,"är gjort av kött", false),
                new Mat(2, "Kött",100,"det kommer från...", false),
                new Mat(3, "skinka",20,"kommer från per i viken", false)

            };
            
        }
        //-------------------------------------------------------------------------------------------------------------------
        




        //--------------------------------------------------------------------------------------------------------------------
        //Den först kör hela programet den andra kör programet utan välkomen menyn
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
        //-------------------------------------------------------------------------------------------------------------------




        //-------------------------------------------------------------------------------------------------------------------
        //Här är utsendet på menyer
        internal static void Welcome()
        {
            Console.Clear();
            Console.Title = "Produkt-Automat";
            Console.ForegroundColor = ConsoleColor.White;
            Utility.PrintCenter("Welcome to Produkt-Automat", Console.WindowWidth);
            
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
            Console.WriteLine("\nThank you for using Produkt-Automat");

            

        }
        //----------------------------------------------------------------------------------------------------------------




        //---------------------------------------------------------------------------------------------------------------
        //Här är vad varje menyval gör den första är för kategori den andra för drinks osv...
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
                    ViewShopingList();
                    Plånboken.Exit();
                    Item.shopingLists.Clear();
                    Utility.PrintMessage("You have successfullt exit the app.", true);

                    
                    Run();
                    break;

                default:
                    Utility.PrintMessage("Invalid Option.", false);
                    break;
            }

        }
        
        internal void ProcessOptionDrinks()
        {
            switch (Validator.Convert<int>("an option"))
            {
                case (int)Option.BuyProdukt:
                    WhoBuyDrinks();


                    break;

                case (int)Option.Description:
                    DrinkDesc();
                    break;

                case (int)Option.Use:
                    UseDrinks();

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
                    KläderDesc();

                    break;

                case (int)Option.Use:
                    UseKläder();

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
                    MatDesc();

                    break;

                case (int)Option.Use:
                    UseMat();
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




       //-------------------------------------------------------------------------------------------------------------------------------------
       //här vissar jag upp produkterna vad jag har att erbyda på
        public void ViewShopingList()
        {
            Console.WriteLine("");
            Console.WriteLine("List of iteams you have purchase");
            foreach (var item in Item.shopingLists)
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



        
        //----------------------------------------------------------------------------------------------------------------------------------------
        //Det här är i beskrivnings menyvalet. Beskrivningen vissa upp 
        public void DrinkDesc() 
        {
            
            Console.WriteLine("What iteam do you want a description of?");
            int number = Validator.Convert<int>("the Id (from the list on top)");

            if (number > Drink.DrinkList.Count)
            {
                Utility.PrintMessage("We don't have that iteam", false);
            }
            else
            {
                for (int i = 0; i <= Drink.DrinkList.Count; i++)
                {

                    if (number == i)
                    {
                        i--;
                        Drink.DrinkList[i]._Description();
                        break;
                    }
                }
            }
            

        }

        public void KläderDesc()
        {

            Console.WriteLine("What iteam do you want a description of?");
            int number = Validator.Convert<int>("the Id (from the list on top)");

            if (number > Kläder.KläderList.Count)
            {
                Utility.PrintMessage("We don't have that iteam", false);
            }
            else
            {
                for (int i = 0; i <= Kläder.KläderList.Count; i++)
                {

                    if (number == i)
                    {
                        i--;
                        Kläder.KläderList[i]._Description();
                        break;
                    }
                }
            }


        }

        public void MatDesc()
        {

            Console.WriteLine("What iteam do you want a description of?");
            int number = Validator.Convert<int>("the Id (from the list on top)");

            if (number > Mat.MatList.Count)
            {
                Utility.PrintMessage("We don't have that iteam", false);
            }
            else
            {
                for (int i = 0; i <= Mat.MatList.Count; i++)
                {

                    if (number == i)
                    {
                        i--;
                        Mat.MatList[i]._Description();
                        break;
                    }
                }
            }


        }
        //--------------------------------------------------------------------------------------------------------------------------




        //-------------------------------------------------------------------------------------------------------------------------
        //Det här är i köp menyvalet. 
        public void WhoBuyDrinks()
        {
            Console.WriteLine("What item do you want from the list on top?");
            int number = Validator.Convert<int>("the Id");

            if (number > Drink.DrinkList.Count)
            {
                Utility.PrintMessage("We don't have that iteam",false);
            }
            else
            {
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
            
        }


        public void WhoBuyKläder()
        {
            Console.WriteLine("What item do you want from the list on top?");
            int number = Validator.Convert<int>("the Id");

            if (number > Kläder.KläderList.Count)
            {
                Utility.PrintMessage("We don't have that iteam", false);
            }
            else
            {
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

            
        }


        public void WhoBuyMat()
        {
            Console.WriteLine("What item do you want from the list on top?");
            int number = Validator.Convert<int>("the Id");

            if (number > Mat.MatList.Count)
            {
                Utility.PrintMessage("We don't have that iteam", false);
            }
            else
            {
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
            


        }
        //------------------------------------------------------------------------------------------------------



        //------------------------------------------------------------------------------------------------------
        //Det här är i use menyvalet
        public void UseDrinks()
        {
            
            
            
                for (int i = 0; i <= Drink.DrinkList.Count; i++)
                {
                    Drink.DrinkList[i].Use();
                    Utility.PressEnterToContinue();
                    break;

                }

            
            
        }

        public void UseKläder()
        {
            for (int i = 0; i < Kläder.KläderList.Count; i++)
            {
                Kläder.KläderList[i].Use();
                Utility.PressEnterToContinue();
                break;
            }
        }

        public void UseMat()
        {
            for (int i = 0; i < Mat.MatList.Count; i++)
            {
                Mat.MatList[i].Use();
                Utility.PressEnterToContinue();
                break;
            }
        }

       //--------------------------------------------------------------------------------------------------------------------------------------------



        //----------------------------------------------------------------------------------------------------------------------------------
        //Denna finns i plånboken menyval
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
        //------------------------------------------------------------------------------------------------------------------------------------------

        















    }
}
