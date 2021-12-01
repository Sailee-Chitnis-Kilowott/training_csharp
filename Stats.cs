using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DotNetAssignment
{
    internal class Stats
    {


        internal int[] Numbers { private get; set; }

        //To calculate mean
        internal decimal CalculateMean()
        {
            int i;
            int sum = 0;
            for (i = 0; i < Numbers.Length; i++)
            {
                sum = sum + Numbers[i];
            }
            return (decimal)sum / Numbers.Length;

        }
        //To calculate median
        internal decimal CalculateMedian()
        {
            int i, j, temp;


            for (i = 0; i < Numbers.Length; i++)
            {
                for (j = i + 1; j < Numbers.Length; j++)
                {
                    if (Numbers[i] > Numbers[j])
                    {
                        temp = Numbers[i];
                        Numbers[i] = Numbers[j];
                        Numbers[j] = temp;
                    }
                }


            }
            if (15 % 2 == 0)
                return (Numbers[(15 - 1) / 2] + Numbers[15 / 2]) / 2;

            else
                return Numbers[15 / 2];

        }

        //To calculate mode
        internal int CalculateMode()
        {

            int i, j, count, maxCount = 0, maxValue = 0;


            for (i = 0; i < Numbers.Length; i++)
            {
                count = 0;
                for (j = 0; j < Numbers.Length; j++)
                {
                    if (Numbers[i] == Numbers[j])
                    {
                        count++;
                    }
                }
                if (count > maxCount)
                {
                    maxCount = count;
                    maxValue = Numbers[i];
                }

            }
            return maxValue;
        }


    }
}
