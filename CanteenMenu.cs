using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicDemo
{
    internal class CanteenMenu
    {
        int quantity;
        double price;
        public void Snacks()
        {
            double pohaprice = 25.00;
            Console.WriteLine("Snacks Item ....");
            Console.WriteLine("Sr.No\tItem Name\t Quantity \tPrice");
            Console.WriteLine("1.\t Poha\t\t 1 plate \t 25.00");
            Console.WriteLine("2.\t Tea\t\t 1 cup \t\t 20.00");
            Console.WriteLine("3.\t Sandwich\t 1 plate \t 50.00");
            int snitem = Convert.ToInt32(Console.ReadLine());
            switch(snitem)
            {

                case 1: { Console.WriteLine("Enter the quantity");
                        quantity = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine(pohaprice * quantity);

                    };

                    break;


            }
        }
        public static void MainMenu()
        { Console.WriteLine("****Welcome to the Staff Canteen****");
            Console.WriteLine("Please choose the items from the below menu");
            Console.WriteLine("1: Snacks");
            Console.WriteLine("2: Lunch");
            Console.WriteLine("3: Dinner");
            Console.WriteLine("4. Exit");
        }
        public static void Main(string[] args)
        {
            CanteenMenu canteenMenu = new CanteenMenu();
            MainMenu();
            canteenMenu.Snacks();
        
        }
    }
}
