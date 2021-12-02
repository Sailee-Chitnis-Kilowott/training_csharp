// See https://aka.ms/new-console-template for more information
using System;
using System.Collections.Generic;
using System.Linq;

namespace ModifiedAssignment
{
    internal class Program
    {
        static int[] data = { 40, 38, 37, 36, 34, 33, 32, 31, 30, 30, 30, 29, 26, 26, 19 };
        int n = 15;
        static void Main(string[] arg)
        {
            var spObject = new Stats();
            spObject.Numbers = data;
            var result = spObject.GetStatsResult();
            //var mean = spObject.CalculateMean();
            // Console.WriteLine($"Mean : {mean}");
            // var median = spObject.CalculateMedian();
            // Console.WriteLine($"Median : {median}");
            // var mode = spObject.CalculateMode();
            // Console.WriteLine($"Mode : {mode}");
            Console.WriteLine($"Mean : {result.Mean}");
            Console.WriteLine($"Median : {result.Median}");
            Console.WriteLine($"Mode : {result.Mode}");
        }


    }

}