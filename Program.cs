// See https://aka.ms/new-console-template for more information


using System;
using System.Collections.Generic;
using System.Linq;

namespace assignment
{
    internal class Program
    {
        static int[] data = { 40, 38, 37, 36, 34, 33, 32, 31, 30, 30, 30, 29, 26, 26, 19 };
        int n = 15;
        static void Main(string[] arg)
        {
            var spObject = new stats();
            spObject.Numbers = data;
            var mean = spObject.CalculateMean();
            Console.WriteLine($"Mean : {mean}");
            var median = spObject.CalculateMedian();
            Console.WriteLine($"Median : {median}");
            var mode = spObject.CalculateMode();
            Console.WriteLine($"Mode : {mode}");

        }
        

    }
    
}

