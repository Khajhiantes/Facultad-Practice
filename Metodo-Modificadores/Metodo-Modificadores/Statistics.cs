using System;
using System.Collections.Generic;
using System.Diagnostics.Metrics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Metodo_Modificadores
{
    internal class Statistics
    {
        public (int moda, int valorMin, int valorMax) ModaMinMax(int[] values)
        {
            Array.Sort(values);

            int valorMax = values[values.Length - 1];
            int valorMin = values[0];
            int maxCount = 0, moda = values[0], count = 1;

            for (int i = 1; i < values.Length; i++)
            {
                if (values[i] == values[i - 1])
                {
                    count++;
                }
                else
                {
                    if (count > maxCount)
                    {
                        maxCount = count;
                        moda = values[i - 1];
                    }
                    count = 1; // reset count for the new number
                }
            }

            // check for the last number in array
            if (count > maxCount)
            {
                moda = values[values.Length - 1];
            }

            return (moda, valorMin, valorMax);

        }
    }
}
