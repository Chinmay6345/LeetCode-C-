using System;
using System.Collections.Generic;

namespace _229_Majority_Element
{
    //https://leetcode.com/problems/majority-element-ii/

    public static class AppHelper
    {
        public static IList<int> MajorityElement(int[] arr)
        {
            IList<Int32> lst = new List<Int32>();
            Int32 num1 = arr[0];
            Int32 num2 = arr[1];
            Int32 count1 = 0;
            Int32 count2 = 0;
            Int32 n = arr.Length;
            for (Int32 i=1;i<n;i++)
            {
                if (num1 == arr[i])
                    count1++;
                if (num2 == arr[i])
                    count2++;
                if (count1 == 0)
                {
                    num1 = arr[i];
                    count1 = 1;
                }
                else if (count2 == 0)
                {
                    num2 = arr[i];
                    count1 = 1;
                }
                else
                {
                    count1--;
                    count2--;
                }

            }
            count1 = 0;
            count2 = 0;
            for(Int32 i=0;i<n;i++)
            {
                if (arr[i] == num1)
                    count1++;
                if (arr[i] == num2)
                    count2++;
            }
            if(count1>=n/3)
            {
                lst.Add(num1);
            }
            if (count2 >= n / 3)
            {
                lst.Add(num2);
            }
            return lst;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }
    }
}
