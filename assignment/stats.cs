using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace assignment
{
    internal class stats
    {

        public static void mean()
        {
            int i, size = 15, sum = 0;
            float resultMean = 0.0F;
            int[] arr = { 40, 38, 37, 36, 34, 33, 32, 31, 30, 30, 30, 29, 26, 26, 19 };
            for (i = 0; i < 15; i++)
            {
                sum = sum + arr[i];
            }
            resultMean = (float)sum / 15;
            Console.Write($"Mean : {resultMean}");
        }

        public static void median()
        {
            int i, j, temp, size = 15;
            int[] arr = { 40, 38, 37, 36, 34, 33, 32, 31, 30, 30, 30, 29, 26, 26, 19 };
            float resultMedian = 0;
            for (i = 0; i < 15; i++)
            {
                for (j = i + 1; j < 15; j++)
                {
                    if (arr[i] > arr[j])
                    {
                        temp = arr[i];
                        arr[i] = arr[j];
                        arr[j] = temp;
                    }
                }


            }
            if (15 % 2 == 0)
                resultMedian = (arr[(15 - 1) / 2] + arr[15 / 2]) / 2;

            else
                resultMedian = arr[15 / 2];
            Console.WriteLine();
            Console.WriteLine($"Median : {resultMedian}");


        }
        public static void mode()
        {
            int i, j, size = 15, count, maxCount = 0, maxValue = 0;
            int[] arr = { 40, 38, 37, 36, 34, 33, 32, 31, 30, 30, 30, 29, 26, 26, 19 };

            for (i = 0; i < 15; i++)
            {
                count = 0;
                for (j = 0; j < 15; j++)
                {
                    if (arr[i] == arr[j])
                    {
                        count++;
                    }
                }
                if (count > maxCount)
                {
                    maxCount = count;
                    maxValue = arr[i];
                }
            }
            Console.WriteLine($"Mode : {maxValue}");

        }

    }
}
