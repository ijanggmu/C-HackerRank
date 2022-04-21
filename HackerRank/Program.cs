using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace HackerRank
{
    public class Program
    {
        static void Main(string[] args)
        {
            //SimpleArraySum
            //List<int> ar = new List<int>() { 1, 2, 3, };
            //SimpleArraySum.sum(ar);
            //Console.ReadLine();


            //AwardPointComparision
            //List<int> alice = new List<int>() { 1, 2, 3 };
            //List<int> bob = new List<int>() { 3, 2, 1 };
            //AwardPointComparision.compare(alice, bob);


            //calculate and print the sum of the elements in an array
            //List<long> num = new List<long>() { 100000001, 100000001, 100000001, 1000000015 };
            //SumOfElementofArray.bigArray(num);
            //Console.WriteLine();
            //Console.ReadLine();

            //int n = Convert.ToInt32(Console.ReadLine().Trim());

            //List<List<int>> arr = new List<List<int>>();

            //for (int i = 0; i < n; i++)
            //{
            //    arr.Add(Console.ReadLine().TrimEnd().Split(' ').ToList().Select(arrTemp => Convert.ToInt32(arrTemp)).ToList());
            //}

            //plus Minus
            //PlusMinus.plusminus();


            //StairCase
            //staircase.staircae(6);

            //MinMax
            //List<int> arr = new List<int>() { 1,2,3,4,5};
            //MinMax.miniMaxSum(arr);
            ////BirthdayCake
            //Console.WriteLine("Please enter no integer: ");
            //int candlesCount = Convert.ToInt32(Console.ReadLine());
            //var candles = new List<int>();
            //for (int i = 0; i < candlesCount; i++)
            //{
            //    Console.WriteLine($"Enter {i+1} no:");
            //    candles.Add(Convert.ToInt32(Console.ReadLine()));
            //}
            //int result = BirthdayCake.birthdayCakeCandles(candles);

            //Console.WriteLine(result);
            //Console.ReadLine();

            //    //TimeConversion
            //    DateTime d = DateTime.Parse(s);
            //    return d.ToString("HH:mm:ss");
            //}
            //var reult = new List<int>();
            //var nmul = new List<int>();
            //var grade = new List<int>() { 84, 90,45,38,39 };
            //for (int i = 0; i < grade.Count; i++)
            //{
            //    int fac = grade[i] % 5;
            //    if (fac == 0 || grade[i]<38)
            //    {
            //        reult.Add(grade[i]);
            //    }
            //    else
            //    {
            //        int mofive = ((grade[i] / 5)+1)*5;
            //        int diff = 5 - fac;
            //        if (diff < 3)
            //        {
            //            reult.Add(mofive);
            //        };



            //    };

            //};
            //foreach(var i in reult){
            //    Console.WriteLine(i);
            //};

            //var apple = new List<int>()
            //{
            //    -2,2,1
            //};
            //var mango = new List<int>()
            //{
            //    5,-6
            //};
            //int countM = 0;
            //int countA = 0;
            //foreach (var i in apple)
            //{
            //    int sumA = i + a;
            //    if (sumA>=s && sumA <= t)
            //    {
            //        countA++;
            //    }

            //}
            //foreach (var i in mango) {
            //    int sumM = i + m;
            //    if (sumM >= s && sumM <= t)
            //    {
            //        countM++;
            //    }

            //    }
            //Console.WriteLine(countA +" "+countM);
            ////apple.ForEach(n =>n.Equals(n+a));
            ////mango.ForEach(n => Console.WriteLine(n+b));          
            ////Console.WriteLine(apple.Sum() +" "+ mango.Sum());
            ////Console.WriteLine($"{countA} a d {countM}");
            ///
            //APplemango problem
            //Console.WriteLine("Enter the no of Apple");
            //int m= Convert.ToInt32(Console.ReadLine());
            //Console.WriteLine("Enter the no of Mango");
            //int n = Convert.ToInt32(Console.ReadLine());
            //Console.WriteLine("Enter the distance of start House");
            //int s = Convert.ToInt32(Console.ReadLine());
            //Console.WriteLine("Enter the distance of end House");
            //int t = Convert.ToInt32(Console.ReadLine());
            //Console.WriteLine("Enter the distance of Apple ");
            //int a = Convert.ToInt32(Console.ReadLine());
            //Console.WriteLine("Enter the distance of Mango ");
            //int b = Convert.ToInt32(Console.ReadLine());

            //var apple = new List<int>();
            //var mango = new List<int>();
            //for(int i=0;i<m;i++)
            //{
            //    Console.WriteLine($"apple {i+1}");
            //    apple.Add(Convert.ToInt32(Console.ReadLine()));
            //};
            //for (int i = 0; i < n; i++)
            //{
            //    Console.WriteLine($"mango {i + 1}");
            //    mango.Add(Convert.ToInt32(Console.ReadLine()));
            //}
            //OrangeApple.OrangeApples(s, t, a, b, apple, mango);

            //maria basketball



            //int[] score = new int[] { 10, 5, 20, 20, 4, 5, 2, 25, 1 };
            //int max = 0;
            //int min = 0;
            //int[] gameCount = new int[score.Length];

            //min= score[0];
            //max = score[0];
            //for (int i=1;i<score.Length;i++)
            //{
            //    if (score[i] >=max)
            //    {
            //         max=score[i];
            //         max++;
            //    }
            //    else
            //    {
            //        min=score[i];
            //        max = score[i - 1];
            //    }

            //};
            //print

            //CamelCase
            //String split = "oneTwoThreeFour";
            //int count = 0;
            //foreach(var i in split)
            //{
            //    if (Char.IsUpper(i))
            //    {
            //        count++;
            //    }

            //}
            //Console.WriteLine(count + 1);
            //Console.WriteLine(WordCounter.wordfunc("oneTwoThree"));
            //string name = "@Ejan21";
            //int u = 0;
            //int l = 0;
            //int d = 0;
            //int s = 0;

            //foreach (var i in name)
            //{
            //    if (char.IsUpper(i))
            //    {
            //        u = 1;
            //    }
            //    else if (char.IsLower(i))
            //    {
            //        l = 1;
            //    }
            //    else if (char.IsDigit(i))
            //    {
            //        d = 1;
            //    }
            //    else
            //    {
            //        s = 1;
            //    }
            //}
            //    int req = 4 - (s + d + l + u);

            //    if (name.Length + req < 6)
            //    {
            //        Console.WriteLine( 6 - name.Length);
            //    }
            //    else
            //    {
            //        Console.WriteLine(req);
            //    }
            //Console.WriteLine( strongPasswordChecker.spc("@Ejan21")); 
            
            Console.WriteLine(  );

            Console.ReadLine();
            
        }
    }
}
    

