using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Program
{

    class VendingItem
    {
        public String Item { get; set; }
        public double Price { get; set; }
        public String Location { get; set; }
        public int Quantity { get; set; }


        public VendingItem(String Item, double Price, String Location, int Quantity)
        {
            this.Item = Item;
            this.Price = Price;
            this.Location = Location;
            this.Quantity = Quantity;
        }


        public void ReduceInventory()
        {
            Quantity -= 1;
        }
    }
}
