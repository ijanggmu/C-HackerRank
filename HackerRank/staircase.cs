using System;
using System.Collections.Generic;
using System.Text;

namespace HackerRank
{
    public class staircase
    {
        public static void staircae(int n)
        {
            for (int i = 1; i <= n; i++)
            {
                for (int j = n; j > i; j--)
                {
                    Console.Write(" ");
                }
                for (int k = 1; k <= i; k++)
                {
                    Console.Write("#");
                }
                Console.WriteLine();

            }

        }
    }
}
