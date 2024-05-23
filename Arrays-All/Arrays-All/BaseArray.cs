using System;
using System.Collections.Generic;
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
            arrayito = new int[5];
        }

        public int[] Arrayito 
        { 
            get { return arrayito; }
            set { arrayito = value; }
        }
        public void RellenarArray(int i)
        {

        }
    }
}
