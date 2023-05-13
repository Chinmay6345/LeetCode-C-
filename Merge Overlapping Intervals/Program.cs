using System;
using System.Collections.Generic;

namespace Merge_Overlapping_Intervals
{
    //https://www.algoexpert.io/questions/Merge%20Overlapping%20Intervals
    //https://leetcode.com/problems/merge-intervals/
    public static class AppHelper
    {
        public static int [][] MergeOverlappingIntervals(int [][] intervals)
        {
            int[][] sortedIntervals = intervals.Clone() as int[][];
            Array.Sort<Int32[]>(sortedIntervals, (a, b) => a[0].CompareTo(b[0]));
            List<int[]> mergedIntervals = new List<int[]>();
            int [] currentInterval = sortedIntervals[0];
            mergedIntervals.Add(currentInterval);

            foreach(int [] nextInterval in sortedIntervals)
            {
                int currentIntervalEnd = currentInterval[1];
                int nextIntervalStart = nextInterval[0];
                int nextIntervalEnd = nextInterval[1];

                if(currentIntervalEnd >nextIntervalStart)
                {
                    currentInterval[1] = Math.Max(currentIntervalEnd, nextIntervalEnd);
                }
                else
                {
                    currentInterval = nextInterval;
                    mergedIntervals.Add(currentInterval);
                }
            }
            return mergedIntervals.ToArray();
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            int[][] arr= new int[][] { new int[] { 1, 2 },new int[] { 3, 5 },new int[] { 4, 7 },new int[] { 6, 8 },new int[] { 9, 10 } };
            var result = AppHelper.MergeOverlappingIntervals(arr);
            Console.ReadLine();
        }
    }
}
