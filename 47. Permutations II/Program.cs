using System;
using System.Collections.Generic;

namespace _47._Permutations_II
{
    //https://leetcode.com/problems/permutations-ii/
    public static class AppHelper
    {
        public static void GetPermutations(int index, int[] arr, ref IList<IList<Int32>> output, List<int> ds)
        {
            if (index == arr.Length - 1)
            {
                output.Add(new List<int>(arr));
                return;
            }
            var set=new HashSet<int>();
            for (int i = index; i < arr.Length; i++)
            {
                if (!set.Contains(arr[i]))
                {
                    set.Add(arr[i]);


                    swap(ref arr, index, i);
                    GetPermutations(index + 1, arr, ref output, ds);
                    swap(ref arr, index, i);
                }
            }
        }
        public static void swap(ref int[] arr, int i, int j)
        {
            int temp = arr[i];
            arr[i] = arr[j];
            arr[j] = temp;
        }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            IList<IList<Int32>> permutations = new List<IList<int>>();
            AppHelper.GetPermutations(0,new int[] {1,2,3,4},ref permutations, new List<int>());
            Console.ReadLine();
        }
    }
}
