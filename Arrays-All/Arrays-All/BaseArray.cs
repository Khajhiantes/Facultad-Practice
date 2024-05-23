using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Arrays_All
{
    internal class BaseArray
    {
        private int[] arrayito;
       

        public BaseArray()
        {
            arrayito = new int[3];
        }

        public int[] Arrayito 
        { 
            get { return arrayito; }
            set { arrayito = value; }
        }
        public void RellenarArray() {           

            for (int i = 0; i < 3; i++)
            { 
                Console.Write($"Enter number {i+1}: ");
                int choice;
                bool isNumber = int.TryParse(Console.ReadLine(), out choice);//validate a number
                if (!isNumber)
                {
                    Console.WriteLine("Invalid num");
                    i--;
                }
                else
                {
                    arrayito[i] = choice;
                }
               
                
            }
            
            
        }
        public void ShowArrays()
        {
            foreach (int i in arrayito)
            {
                Console.WriteLine(i);
            }
        }
        
        
    }
}
