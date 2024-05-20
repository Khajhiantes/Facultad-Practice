// See https://aka.ms/new-console-template for more information
using Shopping_Cart_System;

Store store = new Store();
Cart cart = new Cart(10);

// Add some items to the store's inventory for testing
store.AddItem(new Items { names = "Apple", price = 0.5, quantity = 10 });
store.AddItem(new Items { names = "Banana", price = 0.3, quantity = 8 });
store.AddItem(new Items { names = "Cherry", price = 0.2, quantity = 15 });

while (true)
{
    Console.WriteLine("1. Add item to cart");
    Console.WriteLine("2. Remove item from cart");
    Console.WriteLine("3. View cart");
    Console.WriteLine("4. Checkout");
    Console.WriteLine("5. Exit");
    Console.Write("Enter your choice: ");
    string choice = Console.ReadLine();

    switch (choice)
    {
        case "1":
            Console.Write("Enter item name: ");
            string itemName = Console.ReadLine();
            Console.Write("Enter quantity: ");
            int quantity = int.Parse(Console.ReadLine());

            if (store.IsItemAvailable(itemName, quantity))
            {
                Items item = new Items { names = itemName, price = 0.5, quantity = quantity }; 
                cart.AddItem(item, quantity);
                Console.WriteLine("Item added to cart");
            }
            else
            {
                Console.WriteLine("Item is not available or quantity is too high");
            }
            break;

        case "2":
            Console.Write("Enter item name: ");
            itemName = Console.ReadLine();
            cart.RemoveItems(itemName);
            Console.WriteLine("Item removed from cart");
            break;

        case "3":
            cart.ViewCart();
            break;

        case "4":
            cart.Checkout();
            break;

        case "5":
            return;

        default:
            Console.WriteLine("Invalid choice");
            break;
    }
}