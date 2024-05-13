using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clases_Activity
{
    public class Dice
    {
        private static Random Random = new Random();

        public void bet(int number)
        {
            int randomN= Random.Next(1, 7);
            if (number == randomN)
            {
                Console.WriteLine("You win");
                Console.WriteLine($"You rolled a {number} " );
                Console.WriteLine($"The dice rolled a {randomN}");
            }
            else
            {
                Console.WriteLine("You lose");
                Console.WriteLine($"You rolled a {number}" );
                Console.WriteLine($"The dice rolled a {randomN}" );
            }
        }
    }
}