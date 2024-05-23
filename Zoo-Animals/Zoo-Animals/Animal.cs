using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zoo_Animals
{
    internal class Animal
    {
        private string name;
        public string Name
        {
            get { return name; }
            set { name = value; }
        }
        public virtual void Speak()
        {
            Console.WriteLine("Animal speaks");
        }
    }
}
