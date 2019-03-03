using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Program
{
    class Program
    {
        static List<VendingItem> items = new List<VendingItem>();
        static void Main(string[] args)
        {
            FillMachine();
            while (true)
            {
                DisplayMachine();
                Console.WriteLine("Bill Inserted ($1, $2, $5, or 0 to end)");
                int bill = Int32.Parse(Console.ReadLine());
                Console.WriteLine("You have entered $" + bill + ". PLease make your selection");
                String selection = Console.ReadLine();
                VendingItem sel = items.Find(x => x.Location == selection);
                if (bill < sel.Price)
                {
                    Console.WriteLine("You selected " + sel.Item + " that has a price of $" + sel.Price + ", you entered $" + bill + ". That is not enough");
                    Console.WriteLine("Refunding money \t Press any key to exit");
                    Console.ReadLine();
                }
                else if (sel.Quantity == 0)
                {
                    Console.WriteLine("There are no more " + sel.Item + " left");
                    Console.WriteLine("Refunding money \t Press any key to exit");
                    Console.ReadLine();
                }
                else
                {
                    MakeChange(sel, bill);
                }

            }
            }


        public static void FillMachine()
        {
            items.Add(new VendingItem("Pepsi 20 oz", 2.25, "a1", 6));
            items.Add(new VendingItem("Sierra Mist 20 oz", 2.25, "a2", 5));
            items.Add(new VendingItem("Diet Pepsi 20 oz", 2.25, "a3", 5));
            items.Add(new VendingItem("Snapple Lemon Tea 16 oz", 1.55, "b1", 7));
            items.Add(new VendingItem("Snapple Diet Lemon Tea 16 oz", 1.55, "b2", 6));
            items.Add(new VendingItem("Snapple Raspberry Tea 16 oz", 1.55, "b3", 3));
            items.Add(new VendingItem("Lays Potato Chips", 1.15, "c1", 6));
            items.Add(new VendingItem("Cheetos", 1.05, "c2", 5));
            items.Add(new VendingItem("Doritos Cool Ranch", 1.25, "c3", 8));
            items.Add(new VendingItem("Twix Bar", .95, "d1", 6));
            items.Add(new VendingItem("Kit-Kat", .95, "d2", 6));
            items.Add(new VendingItem("Twizzlers", .85, "d3", 2));
            items.Add(new VendingItem("Juicy Fruit Gum", .55, "e1", 9));
            items.Add(new VendingItem("Tic-Tacs", .90, "e2", 8));
            items.Add(new VendingItem("Doublemint Gum", .65, "e3", 4));
        }

        public static void DisplayMachine()
        {
            Console.Clear();
            Console.WriteLine("Vending Machine");
            Console.WriteLine("");
            Console.WriteLine("~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~");
            int a = 0;
            for (int x = 0; x <= 4; x++)
            {
                Console.WriteLine("~ {0,-40}{1,-40}{2,-40}~", items[a].Location + ": " + items[a].Item, items[a + 1].Location + ": " + items[a + 1].Item, items[a + 2].Location+": "+items[a+2].Item);
                Console.WriteLine("~ {0,-40}{1,-40}{2,-40}~","Price: $" +items[a].Price, "Price: $" + items[a+1].Price, "Price: $" + items[a+2].Price);
                Console.WriteLine("~ {0,-40}{1,-40}{2,-40}~","Quantity Left: " +items[a].Quantity, "Quantity Left: " + items[a+1].Quantity, "Quantity Left: " + items[a+2].Quantity);
                Console.WriteLine("~ {0,-40}{1,-40}{2,-40}~","","","");
                a += 3;
            }
            Console.WriteLine("~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~");

        }

        public static void MakeChange(VendingItem item, int bill)
        {
            Console.WriteLine("Item Vended");
            double change = bill - item.Price;
            Console.WriteLine(change + "Total Change");
            int ones = 0, quarters = 0, dimes = 0, nickels = 0;
            while (change >= 1)
            {
                change -= 1;
                ones++;
            }
            while(change>= .25)
            {
                change -= .25;
                quarters++;
            }
            while (change >= .1)
            {
                change -= .1;
                dimes++;
            }
            while (change >= .05)
            {
                change -=.05;
                nickels++;
            }

            Console.WriteLine(ones + " One dollar bills");
            Console.WriteLine(quarters + "Quarters");
            Console.WriteLine(dimes + "Dimes");
            Console.WriteLine(nickels + "Nickels");
            Console.WriteLine("Press enter to continue");
            Console.ReadLine();
            item.ReduceInventory();
        }
    }
}
