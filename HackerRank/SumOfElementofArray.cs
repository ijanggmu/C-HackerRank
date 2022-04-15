using System;
using System.Collections.Generic;
using System.Text;

namespace HackerRank
{
    public class SumOfElementofArray
    {
        public static long bigArray(List<long> ar)
        {
            long sum = 0;
            for (int i = 0; i < ar.Count; i++)
            {
                sum += ar[i];
            }
            Console.WriteLine(sum);
            return sum;
        }
        
    }
}
