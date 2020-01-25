using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//https://leetcode.com/problems/self-dividing-numbers/submissions/

namespace Self_dividing_numbers
{
    public static class Utility
    {
        public static bool isSelfDividing(int n)
        {
            int currentDigit = 0;
            int actualNumber = n;
            while (n > 0)
            {
                currentDigit = n % 10;
                if ((currentDigit == 0) || (actualNumber % currentDigit != 0))
                {
                    return false;
                }
                n /= 10;
            }
            return true;
        }

        public static List<Int32> SelfDividingNum(Int32 low, Int32 high)
        {
            List<Int32> LstSelfDividingNum = new List<Int32>();
            for (int i = low; i <= high; i++)
            {
                if (isSelfDividing(i))
                {
                    LstSelfDividingNum.Add(i);
                }
            }
            return LstSelfDividingNum;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            foreach(Int32 num in Utility.SelfDividingNum(1,22))
            {
                Console.WriteLine(num);
            }
            Console.ReadLine();
        }
    }
}
