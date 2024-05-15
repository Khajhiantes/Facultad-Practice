using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Flip_a_Coin
{
    internal class Flip_Coin
    {
        public string CoinSide { get; set; }
        public Flip_Coin()
        {
            CoinSide = "";
        }
        public void FlipCoin()
        {
            Random random = new Random();
            int side = random.Next(0, 2);
            if (side == 0)
            {
                CoinSide = "Heads";
            }
            else
            {
                CoinSide = "Tails";
            }
        }
    }
}
