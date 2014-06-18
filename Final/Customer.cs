using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Final
{
    class Customer
    {
        private string name;
        private int custNo;
        private List<Order> nyOrder;

        public Customer(string name, int custNo)
        {
            this.name = name;
            this.custNo = custNo;
            this.nyOrder = new List<Order>();

        }


        public void AddOrder(Order i)
        {
            nyOrder.Add(i);
        }

        public void RemoveOrder(Order i)
        {
            nyOrder.Remove(i);
        }

        public string printOrders()
        {
            string t = null;
            for (int i = 0; i < nyOrder.Count; i++)
            {
                t = t + nyOrder[i] + "\n";
            }
            return t;
        }

        public int CuntNo
        {
            get { return custNo; }
        }


        public string Name
        {
            get { return name; }
        }

        public override string ToString()
        {

            return "\n  Customer: " + name + "  -  Customer no: " + custNo + "\n\n" + printOrders();

        }
    }
}
