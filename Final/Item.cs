using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Final
{
    class Item
    {
        private string itemName;
        private int itemNo;
        private double price;

        public Item(string itemName, int itemNo, double price)
        {
            this.itemName = itemName;
            this.itemNo = itemNo;
            this.price = price;
        }

        public double Price
        {
            get { return price; }
        }
        

        public int ItemNo
        {
            get { return itemNo; }
        }
        

        public string ItemName
        {
            get { return itemName; }
        }


        public override string ToString()
        {

            return "  Product no: " + itemNo + "\n  Product Name: " + itemName + "\n  Product price: " + price;

        }
        
    }
}
