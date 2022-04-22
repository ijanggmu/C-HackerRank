using System;
using System.Collections.Generic;
using System.Text;

namespace HackerRank
{
    public class List
    {
        public static void ls(List<int> arr, List<int> bb)
        {
            foreach(int i in arr)
            {
                Console.WriteLine(i);
            }
            foreach (int i in bb)
            {
                Console.WriteLine(i);
            }
        }
    }
}
