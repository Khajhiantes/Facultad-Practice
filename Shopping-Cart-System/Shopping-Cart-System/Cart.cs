using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shopping_Cart_System
{
    internal class Cart
    {
        Items[] items { get; set; }
        int count = 10;
        public Cart(int i)
        {
            items = new Items[i];
        }
        public void AddItem( Items item, int quantity)
        {
            for (int i = 0; i< items.Length; i++)
            {
                if (items[i]==null)
                {
                    items[i]= item;
                    items[i].quantity = quantity;
                    break;
                }
            }
        }
        public void RemoveItems(string item)
        {
            for (int i = 0; i< items.Length; i++)
            {
                if (items[i]!=null && items[i].names == item)
                {
                    items[i] = null;
                    break;
                }
            }
        }
        public void ViewCart()
        {
            for(int i = 0; i< items.Length; i++)
            {
                if (items[i]!=null)
                {
                    Console.WriteLine("Item Name: " + items[i].names);
                    Console.WriteLine("Item Price: " + items[i].price);
                    Console.WriteLine("Item Quantity: " + items[i].quantity);
                }
            }
        }

        public void Checkout()
        {

            double total = 0;
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] != null)
                {
                    total += items[i].price * items[i].quantity;
                    items[i] = null;
                }
            }
            Console.WriteLine($"Total: {total}");
        }

    }
}
