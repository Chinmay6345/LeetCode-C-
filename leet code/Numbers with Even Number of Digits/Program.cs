using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Numbers_with_Even_Number_of_Digits
{
    //https://leetcode.com/contest/weekly-contest-168/problems/find-numbers-with-even-number-of-digits/
    public static class AppHelper
    {
        public static Int32 GetCount(int [] nums)
        {
            int count = 0;
            foreach(Int32 number in nums)
            {
                int NoOfDigits = (int)Math.Floor(Math.Log10(Math.Abs(number)) + 1);
                if (NoOfDigits % 2 == 0)
                    count++;
            }
            return count;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(AppHelper.GetCount(new int[] { 555, 901, 482, 1771 }));
            Console.ReadLine();
        }
    }
}
