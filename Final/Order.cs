using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Final
{
    class Order
    {
        private int orderNo;
        private List<OrderLine> orderLine;

        public Order(int orderNo)
        {
            this.orderNo = orderNo;
            this.orderLine = new List<OrderLine>();
        }

        public int OrderNo
        {
            get { return orderNo; }
        }

        public void AddOrderline(Item e, int qty)
        {
            OrderLine ord = new OrderLine(qty, e, this);
            orderLine.Add(ord);
        }

        //public List<Item> GetOrderline()
        //{
        //    List<Item> returnList = new List<Item>();
        //    foreach (OrderLine ord in orderLine)
        //    {
        //        returnList.Add(ord.Items);
        //    }
        //    return returnList;
        //}

        public string printOrderLines()
        {
            string t = null;
            for (int i = 0; i < orderLine.Count; i++)
            {
                t = t + orderLine[i] + "\n";
            }
            return t;
        }

        public override string ToString()
        {

            return "  Order no: " + orderNo + "\n  ...............................\n\n" + printOrderLines() + "\n  Order no: " + orderNo + "   Total Price: " + GetTotalPrice() + "\n  ===============================\n        VAT: " + GetTotalPrice() * 0.20 +"\n\n";

        }

        public double GetTotalPrice()
        {
            double sum = 0;
            for (int i = 0; i < this.orderLine.Count; i++)
            {
                //sum = sum + (this.orderLine[i].Items.Price * orderLine[i].Qty);
                sum = sum + this.orderLine[i].TotalProductPrice();
            }
            return sum;
        }
        
    }
}
