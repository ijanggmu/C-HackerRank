using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace HackerRank
{
    public class CheckRank
    {
        public static List<int> checkresult(List<int> rank,List<int> player)
        {
            
            List<int> result = new List<int>();
            var cleanrank = rank.ToHashSet().ToArray();
            int j = cleanrank.Length - 1;
            for (int i = 0; i < player.Count; i++)
            {
                bool rankfound = false;
                while (!rankfound && j >= 0)
                {
                    if (player[i] < cleanrank[j])
                    {
                        result.Add(j + 2);
                        rankfound = true;
                    }
                    else if (player[i] == cleanrank[j])
                    {
                        result.Add(j + 1);
                        rankfound = true;
                    }
                    else
                    {
                        j--;
                    }
                }
                if (!rankfound)
                {
                    result.Add(1);
                }
            }
            return result;
        }
        
    }
}
