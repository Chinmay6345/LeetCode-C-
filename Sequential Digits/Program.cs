using System;
using System.Collections.Generic;
using System.Linq;

namespace Sequential_Digits
{
    public static class AppHelper
    {
        public static void GetCount(int num)
        {
            //int remainder = 0;
            //List<int> listOfInts = new List<int>();
            //while (num > 0)
            //{
            //    remainder = num % 10;
            //    listOfInts.Add(remainder);
            //    num = num / 10;
            //}
            int[] nums = { 1, 1, 1, 2, 2, 3 };
            var r = nums.GroupBy(x => x)
               .Where(g => g.Count() >= 1)
              .Select(y => new { Element = y.Key, Counter = y.Count() });
            int count = 0;
            foreach(var item in r)
            {
                if(item.Counter==1 || item.Counter==2)
                {
                    count = count + item.Counter;
                }
                else
                {
                    count = count +  2;
                }
            }
            int p = 2;
        }
    }

    public class Program
    {
        public static void Main(string[] args)
        {
           
            AppHelper.GetCount(123);
            Console.ReadLine();
        }
    }
}
