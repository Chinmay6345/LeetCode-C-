using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//https://leetcode.com/problems/power-of-two/submissions/
namespace Power_of_two
{
    public static class AppHelper
    {
        public static Boolean PowerofTwo(Int32 n)
        {
            if (n == 0)
            {
                return false;
            }
            while (n != 1)
            {
                if (n % 2 != 0)
                {
                    return false;
                }
                n = n / 2;
            }
            return true;
        }
    }
    public class Solution
    {
        public bool IsPowerOfTwo(int n)
        {
            return AppHelper.PowerofTwo(n);
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
        }
    }
}
