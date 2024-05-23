using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Arrays_All
{
    internal class SistemArrays
    {
        BaseArray [] baseArray {  get; set; }
        
        public SistemArrays()
        {
            baseArray = new BaseArray[10];
        }
        public void AddArray(BaseArray arr)
        {
            for (int i = 0; i<baseArray.Length; i++)
            {
                if (baseArray[i] == null)
                {
                    baseArray[i]= arr;
                }
            }
        }

        
    }
}
