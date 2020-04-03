using System;
using System.Collections.Generic;
using System.Linq;

//https://leetcode.com/problems/sort-array-by-parity/
namespace Sort_Array_By_Parity
{
    public static class AppHelper
    {
        //using linq
        public static Int32[] Sorted(Int32[] array)
        {
            return array.OrderBy(a => a % 2 == 0 ? -a : a).ToArray();
        }
        //using two pointer
        public static Int32[] Sort(Int32[] arr)
        {
            Int32 temp;
            if (arr.Length == 1 || arr.Length == 0)
            {
                return arr;
            }
            Int32 i = 0;
            Int32 j = arr.Length - 1;
            while (i < j)
            {
                if (arr[i] % 2 != 0)
                {
                    temp = arr[i];
                    arr[i] = arr[j];
                    arr[j] = temp;
                    j--;
                }
                else
                {
                    i++;
                }
            }
            return arr;
        }
        
    }

    class Program
    {
        static void Main(string[] args)
        {
            Int32[] array = AppHelper.Sorted(new int[] { 4, 1, 3, 2 });
            Console.Write(String.Join(" ", array.Select(a => a)));
        }
    }
}
