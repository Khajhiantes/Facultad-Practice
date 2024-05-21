using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Simple_Inventory_System
{
    internal class SystemInventory
    {
        Items [] item { get; set; }
        int count = 0;
        public SystemInventory(int i)
        {
            item = new Items[i];
        }
        public void AddItem(Items information)
        {
            for (int i=0; i< item.Length; i++)
            {
                if (item[i]==null){
                    item[i] = information;
                    count++;
                    Console.WriteLine("Item add succesfully");
                    Console.WriteLine($"Item Id:{item[i].id} ");
                    Console.WriteLine($"Item name: {item[i].name}");
                    Console.WriteLine($"Item quantity: {item[i].quantity}");
                    Console.WriteLine($"Item price: {item[i].price}");
                    break;
                }
            }
        }
        public void UpdateQuantity(int id, int quantity)
        {
            for (int i = 0; i< count; i++)
            {
                if (item[i].id == id)
                {
                    item[i].quantity = quantity;
                }
            }
        }

        public void ShowItem(int id)
        {
            for (int i = 0; i < count; i++)
            {
                if (item[i].id == id)
                {
                    Console.WriteLine("Item details");
                    Console.WriteLine($"Item Id:{item[i].id} ");
                    Console.WriteLine($"Item name: {item[i].name}");
                    Console.WriteLine($"Item quantity: {item[i].quantity}");
                    Console.WriteLine($"Item price: {item[i].price}");
                    break;
                }
            }
        }

        public void RemoveItem(int id)
        {
            for (int i = 0; i< count; i++)
            {
                if (item[i].id == id)
                {
                    for (int j = i; j < count - 1; j++)
                    {
                        item[j] = item[j + 1];
                        
                    }
                    count--;
                    Console.WriteLine("Item removed succesfully");
                    break;
                }
            }
        }
        public void ShowItems()
        {
            for (int i = 0; i < count; i++)
            {
                    Console.WriteLine("Item details");
                    Console.WriteLine($"Item Id:{item[i].id} ");
                    Console.WriteLine($"Item name: {item[i].name}");
                    Console.WriteLine($"Item quantity: {item[i].quantity}");
                    Console.WriteLine($"Item price: {item[i].price}");
                    Console.WriteLine("_____________________________");

            }  
        }


    }
}
