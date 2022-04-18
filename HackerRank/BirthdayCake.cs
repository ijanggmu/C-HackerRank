using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace HackerRank
{
    public class BirthdayCake
    {
        public static int birthdayCakeCandles(List<int> candles)
        {
            int max = candles.First();
            int count = 1;
            for (int i = 1; i < candles.Count; i++)
            {
                if (candles[i] > max)
                {
                    max = candles[i];
                    count = 1;
                }
                else if (candles[i] == max)
                {
                    count++;
                }
            }
            return count;
        }

    }


}

