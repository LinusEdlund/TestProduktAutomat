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
    public class Mat : Iteam, IOption
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
                Utility.PrintMessage($"You dont have enough money to buy {this.Name}. Check Plånbok to see your account balance", false);
            }

        }

        public void Use()
        {
            throw new NotImplementedException();
        }

        void IOption.Description()
        {
            throw new NotImplementedException();
        }
    }
}
