﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Flip_a_Coin
{
    internal class Player
    {
        public string Name { get; set; }
        public int Score { get; set; }
        public Player(string name)
        {
            Name = name;
            Score = 0;
        }

    }
}
