using System;
using System.Collections.Generic;
using System.Text;

namespace HackerRank
{
    public class SimpleArraySum
    {
        public static int sum(List<int> ar)
        {
            var result = 0;
            for (int i = 0; i < ar.Count; i++)
            {
                result += ar[i];
            }
            Console.WriteLine($"sum is {result}");

            return result;
        }
    }
}
