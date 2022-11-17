using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TestProduktAutomat.Domain.Abstrakt;
using TestProduktAutomat.Domain.Interface;
using TestProduktAutomat.Domain.Plånbok;
using TestProduktAutomat.UI;

namespace TestProduktAutomat.Domain.Entities
{
    public class Mat : Item, IOption
    {
        public DateTime Bästföre { get; set; }

        public static List<Mat> MatList = new List<Mat>();


        public Mat(int id, string name, int prize, string beskrivning, bool sold) : base(id, name, prize, beskrivning, sold)
        {

        }

        
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
                        Utility.PrintMessage($"\nYou have now successfully purchased {this.Name} for {this.Prize}\n");

                        ShopingList s = new ShopingList(this.Name, this.Prize);
                        shopingLists.Add(s);

                        this.Sold = true;

                        Plånboken.summa -= this.Prize;
                    }

                    else
                    {
                        Utility.PrintMessage("You have canceled it", false);
                    }

                }
                else
                {
                    Utility.PrintMessage($"\n{this.Name} is no longer available", false);

                }

            }
            else
            {
                Utility.PrintMessage($"You dont have enough money to buy {this.Name}. Check Plånbok to see your account balance", false);
            }

        }

        public void Use()
        {
            Console.WriteLine("Den här produkten används för att ätas");
        }

        public void _Description()
        {
            if (Sold == false)
            {
                Console.WriteLine("");
                Console.WriteLine($"Here is the description of {this.Name}:");
                Console.WriteLine(this.Beskrivning);
                Utility.PressEnterToContinue();
            }
            else
            {
                Utility.PrintMessage($"This item is no longer availble",false);
            }
            
        }
    }
}
