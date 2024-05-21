using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Simple_Inventory_System
{
    internal class Menu
    {
        public void showMenu() 
        {

            SystemInventory inventory = new SystemInventory(10);
            bool exit = true;

            while (exit)
            {
                Console.WriteLine("1. Add Item");
                Console.WriteLine("2. Update Quantity");
                Console.WriteLine("3. Show Item");
                Console.WriteLine("4. Remove Item");
                Console.WriteLine("5. Show Items");
                Console.WriteLine("6. Exit");
                Console.WriteLine("Enter your choice");
                int choice;
                bool isNumber = int.TryParse(Console.ReadLine(), out choice);
                if (!isNumber)
                {
                    Console.WriteLine("Invalid Choice");
                    continue;
                }
                switch (choice)
                {
                    case 1:
                        Console.WriteLine("Introduce ID: ");
                        int id;
                        bool isId = int.TryParse(Console.ReadLine(), out id);
                        if (!isId)
                        {
                            Console.WriteLine("Invalid ID");
                            break;
                        }
                        Console.WriteLine("Introduce Name: ");
                        string name = Console.ReadLine();
                        Console.WriteLine("Introduce Quantity: ");
                        int quantity;
                        bool isQuantity = int.TryParse(Console.ReadLine(), out quantity);
                        if (!isQuantity)
                        {
                            Console.WriteLine("Invalid Quantity");
                            break;
                        }
                        Console.WriteLine("Introduce Price: ");
                        double price;
                        bool isPrice = double.TryParse((Console.ReadLine()), out price);
                        if (!isPrice)
                        {
                            Console.WriteLine("Invalid Price");
                            break;
                        }
                        Items item = new Items();
                        item.id = id;
                        item.name = name;
                        item.quantity = quantity;
                        item.price = price;
                        inventory.AddItem(item);
                        break;
                    case 2:
                        Console.WriteLine("Introduce ID: ");
                        int idUpdate;
                        bool isIdUpdate = int.TryParse(Console.ReadLine(), out idUpdate);
                        if (!isIdUpdate)
                        {
                            Console.WriteLine("Invalid ID");
                            break;
                        }
                        Console.WriteLine("Introduce Quantity: ");
                        int quantityUpdate;
                        bool isQuantityUpdate = int.TryParse(Console.ReadLine(), out quantityUpdate);
                        if (!isQuantityUpdate)
                        {
                            Console.WriteLine("Invalid Quantity");
                            break;
                        }
                        inventory.UpdateQuantity(idUpdate, quantityUpdate);
                        break;
                    case 3:
                        Console.WriteLine("Introduce ID: ");
                        int idShow;
                        bool isIdShow = int.TryParse(Console.ReadLine(), out idShow);
                        if (!isIdShow)
                        {
                            Console.WriteLine("Invalid ID");
                            break;
                        }
                        inventory.ShowItem(idShow);
                        break;
                    case 4:
                        Console.WriteLine("Introduce ID: ");
                        int idRemove;
                        bool isIdRemove = int.TryParse(Console.ReadLine(), out idRemove);
                        if (!isIdRemove)
                        {
                            Console.WriteLine("Invalid ID");
                            break;
                        }
                        inventory.RemoveItem(idRemove);
                        break;
                    case 5:
                        inventory.ShowItems();
                        break;
                    case 6:
                        exit = false;
                        break;
                    default:
                        Console.WriteLine("Invalid Choice");
                        break;
                }
            }



        }

    }
}
