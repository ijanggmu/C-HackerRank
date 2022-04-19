using System;
using System.Collections.Generic;
using System.Text;

namespace HackerRank
{
    public class strongPasswordChecker
    {
        public static int spc(string a)
        {
            int u = 0;
            int l = 0;
            int d = 0;
            int s = 0;

            foreach (var i in a)
            {
                if (char.IsUpper(i))
                {
                    u = 1;
                }
                else if (char.IsLower(i))
                {
                    l = 1;
                }
                else if (char.IsDigit(i))
                {
                    d = 1;
                }
                else
                {
                    s = 1;
                }
            }
            int req = 4 - (s + d + l + u);

            if (a.Length + req < 6)
            {
                return 6 - a.Length;
            }
            else
            {
                return req;
            }
        }
    }
}
