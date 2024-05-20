using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shopping_Cart_System
{
    internal class Store
    {
        public Items[] Inventory { get; set; }

        public Store()
        {
            Inventory = new Items[10];
        }

        public void AddItem(Items item)
        {
            for (int i = 0; i < Inventory.Length; i++)
            {
                if (Inventory[i] == null)
                {
                    Inventory[i] = item;
                    break;
                }
            }
        }

        public bool IsItemAvailable(string itemName, int quantity)
        {
            for (int i = 0; i < Inventory.Length; i++)
            {
                if (Inventory[i] != null && Inventory[i].names == itemName && Inventory[i].quantity >= quantity)
                {
                    return true;
                }
            }
            return false;
        }
    }
}
