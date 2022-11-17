using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Diagnostics;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;
using System.Transactions;
using TestProduktAutomat.Domain.Abstrakt;
using TestProduktAutomat.Domain.Enums;
using TestProduktAutomat.Domain.Interface;
using TestProduktAutomat.Domain.Plånbok;
using TestProduktAutomat.UI;
using Validator = TestProduktAutomat.UI.Validator;

namespace TestProduktAutomat.Domain.Entities
{
    public class Drink : Item, IOption
    {
        

        public static List<Drink> DrinkList = new List<Drink>();



        public Drink(int id, string name, int prize, string beskrivning, bool sold) : base(id, name, prize, beskrivning, sold)
        {

        }

        //här är vad som händer efter man har valt vilken produkt man vill köpa
        public void Buy()
        {
            if (Plånboken.summa >= this.Prize)
            {
                if (Sold == false)
                {

                    Console.WriteLine($"Are you sure you want to buy {this.Name} for {this.Prize}kr");
                    int opt = Validator.Convert<int>("1 to confirm 2 to cancel");
                    if (opt == 1)
                    {
                        Utility.PrintMessage($"\nYou have now successfully purchased {this.Name} for {this.Prize}kr\n");

                        ShopingList s = new ShopingList(this.Name, this.Prize);
                        shopingLists.Add(s);

                        this.Sold = true;

                        Plånboken.summa -= this.Prize;
                    }
                    else
                    {
                        Utility.PrintMessage("You have canceled it",false);
                    }
                    


                }
                else
                {
                    Utility.PrintMessage($"\n{this.Name} is no longer available", false);

                }

            }
            else
            {
                Utility.PrintMessage($"You dont have enough money to buy {this.Name}. Check Plånbok to see your account balance",false);
            }


            
            






        }

        public void Use()
        {
            //Vet inte riktig vad som ska vara i use hoppas det var bara det här du vill ha :D
            Console.WriteLine("Den här produkten används för att drickas");
            
        }

        public void _Description()
        {
            //här vissas beskrivningen 
            if (Sold == false)
            {
                Console.WriteLine("");
                Console.WriteLine($"Here is the description of {this.Name}:");
                Console.WriteLine(this.Beskrivning);
                Utility.PressEnterToContinue();
            }
            else
            {
                Utility.PrintMessage($"This item is no longer availble", false);
            }
        }
    }
}
