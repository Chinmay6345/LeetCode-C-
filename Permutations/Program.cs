using System;
using System.Collections.Generic;
namespace Permutations
{
    public static class AppHelper
    {
        //Tc=Sc=O(n!*n)
        public static List<List<Int32>>Permutations(List<Int32>array)
        {
            List<List<Int32>> permutations = new List<List<int>>();
            GetPermutations(0, ref array, ref permutations);
            return permutations;
        }
        public static void GetPermutations(Int32 i,ref List<Int32>array,ref List<List<Int32>>permutations)
        {
            if(i==array.Count-1)
            {
                permutations.Add(new List<Int32>(array));
            }
            else
            {
                for(int j=i;j<array.Count;j++)
                {
                    Swap(ref array, i, j);
                    GetPermutations(i + 1, ref array, ref permutations);
                    Swap(ref array, i, j);
                }
            }
        }
        public static void Swap(ref List<Int32> array,int i,int j)
        {
            int temp = array[i];
            array[i] = array[j];
            array[j] = temp;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            var result = AppHelper.Permutations(new List<Int32>() { 1, 2, 3 });
            Console.ReadLine();
        }
    }
}
