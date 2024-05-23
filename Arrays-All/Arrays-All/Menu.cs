using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Principal;
using System.Text;
using System.Threading.Tasks;

namespace Arrays_All
{
    internal class Menu
    {
        public void ShowMenu()
        {

            SistemArrays sistemita =    new SistemArrays();
            bool exit = true;
            while (exit)
            {
                Console.WriteLine("1. Add a array");
                Console.WriteLine("2. Remove a array");
                Console.WriteLine("3. Show arrays");
                Console.WriteLine("4. Exit");
                Console.WriteLine("Enter your choice: ");
                int choice;
                bool isNumber = int.TryParse(Console.ReadLine(), out choice);//validate a number
                if (!isNumber)
                {
                    Console.WriteLine("Invalid choice");
                    continue;
                }
                switch (choice)
                {
                    case 1:
                        Console.WriteLine("Introduce the array: ");     
                        BaseArray arrayto = new BaseArray();
                        arrayto.RellenarArray();
                        sistemita.AddArray(arrayto);

                        break;
                    case 2:
                        Console.WriteLine("Introduce the number array to remove: ");
                        int choice2;
                        bool isNumber2 = int.TryParse(Console.ReadLine(), out choice2);//validate a number
                        if (!isNumber2)
                        {
                            Console.WriteLine("Invalid num");
                            continue;
                        }
                        sistemita.RemoveArray(choice2);
                        break;
                    case 3:
                        Console.WriteLine("Show arrays ");
                        sistemita.ShowArray();
                        break;
                    case 4:
                        exit = false;
                        break;
                    default:
                        Console.WriteLine("Invalid choice");
                        break;

                }
            }
        }

    }
}
