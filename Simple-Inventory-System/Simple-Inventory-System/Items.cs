using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Simple_Inventory_System
{
    internal class Items
    {
        private string name { get; set; }
        private int id { get; set; }
        private int quantity { get; set; }
        private double price { get; set; }

        public string GetName()
        {
            return name;
        }
        public void SetName(string name)
        {
            this.name = name;
        }
        public int GetId()
        {
            return id;
        }
        public void SetId(int id)
        {
            this.id = id;
        }
        public int GetQuantity()
        {
            return quantity;
        }
        public void SetQuantity(int quantity)
        {
            this.quantity = quantity;
        }
        public double GetPrice()
        {
            return price;
        }
        public void SetPrice(double price)
        {
            this.price = price;
        }

    }
}
