using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TestProduktAutomat.Domain.Entities;
using TestProduktAutomat.Domain.Plånbok;

namespace TestProduktAutomat.Domain.Abstrakt
{
    public abstract class Item
    {

        public int Id { get; set; }
        public string Name { get; set; }
        public int Prize { get; set; }
        public string Beskrivning { get; set; }
        public bool Sold { get; set; }

        public static List<ShopingList> shopingLists = new List<ShopingList>();


        public Item(int id, string name, int prize, string beskrivning, bool sold)
        {
            this.Id = id;
            this.Name = name;
            this.Prize = prize;
            this.Beskrivning = beskrivning;
            this.Sold = sold;
        }


        public string Display
        {
            get
            {
                return string.Format("{2}. {0} - {1}kr", this.Name, this.Prize, this.Id);
            }
        }

        
        
       
       

    }
}
