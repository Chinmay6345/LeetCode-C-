using System;
using System.Collections.Generic;
using System.Linq;

namespace Palindrome_Number
{
    //https://leetcode.com/problems/palindrome-number/

    public static class AppHelper
    {
       public static Boolean IsPalindrome(int number)
       {
            Int32 reverse = 0;
            Int32 originalnumber = number;
            Boolean isValid = false;
            if (number < 0)
                return false;
            else
            {
                while(number >0)
                {
                    reverse = (reverse *10) + number % 10;
                    number = number / 10;

                }
                if (reverse == originalnumber)
                    isValid = true;
            }
            return isValid;
       }
    }

    public class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine(AppHelper.IsPalindrome(121));
            Console.ReadLine();
        }
    }
}
