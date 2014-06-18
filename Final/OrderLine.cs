using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Final
{
    class OrderLine
    {
        private int qty;
        private Item b;

        public OrderLine(int qty, Item b, Order o)
        {
            this.qty = qty;
            this.b = b;

        }

        public int Qty
        {
            get { return qty; }
        }

        public Item Items
        {
            get { return b; }
        }


        public double TotalProductPrice()
        {
            double pris = b.Price * qty;
            return pris;
        }


        public override string ToString()
        {

            return b + "\n\n  Total Purchased: " + qty + "\n  Total Product Price: " + TotalProductPrice() + "\n  -------------------------";

        }
        
    }
}
