using System;
using System.Collections.Generic;
using System.Text;

namespace HackerRank
{
    public class WordCounter
    {
        public static int wordfunc(string a)
        {
            int count = 0;
            foreach (var i in a)
            {
                if (Char.IsUpper(i))
                {
                    count++;
                }

            }
            int Tcount=count + 1;
            return Tcount;
        }
    }
}
