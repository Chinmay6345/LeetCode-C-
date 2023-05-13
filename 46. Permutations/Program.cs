using System;
using System.Collections.Generic;

namespace _46._Permutations
{
    //https://leetcode.com/problems/permutations/
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }
    }

    public static class AppHelper
    {
        public static void GetPermutations(int index, int[] arr, ref IList<IList<Int32>> output)
        {
            if (index == arr.Length - 1)
            {
                output.Add(new List<int>(arr));
                return;
            }
            for (int i = index; i < arr.Length; i++)
            {
                swap(ref arr, index, i);
                GetPermutations(index + 1, arr, ref output);
                swap(ref arr, index, i);
            }
        }
        public static void swap(ref int[] arr, int i, int j)
        {
            int temp = arr[i];
            arr[i] = arr[j];
            arr[j] = temp;
        }
    }
    public class Solution
    {
        public IList<IList<int>> Permute(int[] nums)
        {
            IList<IList<Int32>> permutations = new List<IList<int>>();
            AppHelper.GetPermutations(0, nums, ref permutations);
            return permutations;
        }
    }
}
