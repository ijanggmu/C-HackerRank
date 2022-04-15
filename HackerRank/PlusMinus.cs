using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace HackerRank
{
    public class PlusMinus
    {
        public static void plusminus() { 
        List<int> arr = new List<int>() { 1, 2, -8, -9, 0 };
        int countzero = 0;
        int countpositive = 0;
        int countnegative = 0;
            for (int i = 0; i<arr.Count; i++)
            {
                if (arr[i] == 0)
                {
                    countzero+=1;
                }
                else if (arr[i] > 0)
                {
                    countpositive+=1;
                }
                else if (arr[i] < 0)
                    {
                     countnegative += 1;
                }

            }
            Console.WriteLine((decimal)countpositive / arr.Count());
            Console.WriteLine((double)countnegative / arr.Count());
            Console.WriteLine((double)countzero / arr.Count());
    }
}
}
