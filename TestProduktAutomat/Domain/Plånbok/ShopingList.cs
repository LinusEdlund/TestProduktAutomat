using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Transactions;
using TestProduktAutomat.Domain.Abstrakt;
using TestProduktAutomat.Domain.Entities;
using TestProduktAutomat.Domain.Enums;

namespace TestProduktAutomat.Domain.Plånbok
{
    public class ShopingList 
    {
        

        public string ItemName { get; set; }
        public Decimal TransactionAmount { get; set; }

        


        public ShopingList(string itemName, decimal transactionAmount)
        {
            ItemName = itemName;
            TransactionAmount = transactionAmount;
        }

        public string DisplayList
        {
            get
            {
                return string.Format("{0} - {1}kr", this.ItemName, this.TransactionAmount);
            }
        }


    }
}

