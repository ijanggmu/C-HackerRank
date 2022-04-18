using System;
using System.Collections.Generic;
using System.Text;

namespace HackerRank
{
    public class OrangeApple
    {
        public static void OrangeApples(int s ,int t,int m,int n,List<int> apple,List<int> mango)
        {
            int countM = 0;
            int countA = 0;
            foreach (var i in apple)
            {
                int sumA = i + m;
                if (sumA >= s && sumA <= t)
                {
                    countA++;
                }

            }
            foreach (var i in mango)
            {
                int sumM = i + n;
                if (sumM >= s && sumM <= t)
                {
                    countM++;
                }

            }
            Console.WriteLine(countA + " " + countM);
            //apple.ForEach(n =>n.Equals(n+a));
            //mango.ForEach(n => Console.WriteLine(n+b));          
            //Console.WriteLine(apple.Sum() +" "+ mango.Sum());
            Console.WriteLine($"{countA} a d {countM}");
        }
    }
}
