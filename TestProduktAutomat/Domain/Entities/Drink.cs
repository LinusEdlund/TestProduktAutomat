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

namespace TestProduktAutomat.Domain.Entities
{
    public class Drink : Iteam, IOption
    {
        public int Amount { get; set; }

        public static List<Drink> DrinkList = new List<Drink>();



        public Drink(int id, string name, int prize, string beskrivning, int amount, bool sold) : base(id, name, prize, beskrivning, sold)
        {

        }


        public void Buy()
        {
            if (Plånboken.summa >= this.Prize)
            {
                if (Sold == false)
                {

                    Utility.PrintMessage($"\nYou have now successfully purchased {this.Name} for {this.Prize}\n");

                    ShopingList s = new ShopingList(this.Name, this.Prize);
                    shopingLists.Add(s);

                    this.Sold = true;

                    Plånboken.summa -= this.Prize; 


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
            Console.WriteLine("Den här produkten används för att drickas");
            
        }

        void IOption.Description()
        {
            throw new NotImplementedException();
        }

       






        



      
    }
}
