using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace HackerRank
{
    public class MinMax
    {
        public static void miniMaxSum(List<int> arr)
        {
            int[] num = new int[5];
            for (int i = 0; i < arr.Count(); i++)
            {
                num[i] = arr.Sum() - arr[i];
            }
            var maxsum = num.Max();
            var minsum = num.Min();
            Console.WriteLine($"{minsum} {maxsum}");

        }

    }
}
