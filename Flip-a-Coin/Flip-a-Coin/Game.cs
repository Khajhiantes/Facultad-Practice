using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Flip_a_Coin
{
    internal class Game
    {
        private Player player1;
        private Player player2;
        private Flip_Coin coin;
        public Game(string player1Name, string player2Name)
        {
            player1 = new Player(player1Name);
            player2 = new Player(player2Name);
            coin = new Flip_Coin();
        }
        public void Play()
        {
            while (player1.Score < 3 && player2.Score < 3)
            {
                coin.FlipCoin();
                Console.WriteLine($"{player1.Name} flips {coin.CoinSide}");
                coin.FlipCoin();
                Console.WriteLine($"{player2.Name} flips {coin.CoinSide}");
                if (coin.CoinSide == "Heads")
                {
                    player1.Score++;
                    Console.WriteLine($"{player1.Name} wins this round!");
                }
                else
                {
                    player2.Score++;
                    Console.WriteLine($"{player2.Name} wins this round!");
                }
            }
            if (player1.Score == 3)
            {
                Console.WriteLine($"{player1.Name} wins the game!");
            }
            else
            {
                Console.WriteLine($"{player2.Name} wins the game!");
            }
        }
    }
}
