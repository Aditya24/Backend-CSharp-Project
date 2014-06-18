using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Final
{
    class Program
    {
        static void Main(string[] args)
        {


            Item item1 = new Item("Milk", 3, 20.3);
            Item item2 = new Item("Cheese", 8, 30.3);
            Item item3 = new Item("Fruits", 8, 1.3);

            Customer Customer1 = new Customer("John Smith", 1);

            Order order1 = new Order(1);
            Order order2 = new Order(2);

            order1.AddOrderline(item1, 40);
            order1.AddOrderline(item2, 10);

            Customer1.AddOrder(order1);

            Console.BackgroundColor = ConsoleColor.White;
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.Black;
            Console.WriteLine(Customer1);
            Console.ReadLine();

        }
    }
}






