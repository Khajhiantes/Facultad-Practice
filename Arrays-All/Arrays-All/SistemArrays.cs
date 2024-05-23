using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace Arrays_All
{
    internal class SistemArrays
    {
        BaseArray [] baseArray {  get; set; }
        int count = 0;
        public SistemArrays()
        {
            baseArray = new BaseArray[10];
        }
        public void AddArray(BaseArray arr)
        {
            for (int i = 0; i < baseArray.Length; i++)
            {
                if (baseArray[i] == null)
                {
                    baseArray[i] = arr;
                    count++;
                    break;
                }
            }

        }
        public void RemoveArray(int key)
        {
            key = key - 1;
            for (int i =0; i< count; i++)
            {
                if(i==key)
                {
                    for (int j=key; j<count-1; j++)
                    {
                        baseArray[j] = baseArray[j + 1];
                    }
                    baseArray[count - 1] = null;
                    count--;
                    break;
                }
            }

        }
        public void ShowArray()
        {
            for (int i = 0; i < count; i++)
            {
              Console.WriteLine($"Array {i + 1}"); 
              baseArray[i].ShowArrays();
            }
        }
    }
}
