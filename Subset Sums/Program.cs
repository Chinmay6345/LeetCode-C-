using System;
using System.Collections.Generic;
using System.Linq;

namespace Subset_Sums
{
    //https://practice.geeksforgeeks.org/problems/subset-sums2234/1#
    public static class AppHelper
    {
        public static void SubSetSums(int [] arr,int index,int sum,ref List<int>lst)
        {
            if(index==arr.Length-1)
            {
                lst.Add(sum);
                return;
            }
            SubSetSums(arr,index+1, sum + arr[index], ref lst);
            SubSetSums(arr,index + 1, sum, ref lst);
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] arr = { 3, 1, 2 };
            Array.Sort(arr);
            List<int> lst = new List<int>();
            AppHelper.SubSetSums(arr,0, 0, ref lst);
            lst.ForEach(delegate (int i) {
                Console.WriteLine(i);
            });
            Console.ReadLine();
        }
    }
}
