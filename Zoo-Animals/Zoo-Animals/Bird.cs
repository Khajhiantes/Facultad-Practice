using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zoo_Animals
{
    internal class Bird : Animal
    {
        public override void Speak()
        {
            Console.WriteLine("Bird sings");
        }
    }
}
