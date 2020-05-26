using System;
//https://leetcode.com/problems/number-of-students-doing-homework-at-a-given-time/
namespace Number_of_Students_Doing_Homework_at_a_Given_Time
{
    public static class AppHelper
    {
        public static Int32 BusyStudent(Int32[] startTime, Int32[] endTime, Int32 queryTime)
        {
            Int32 count = 0;
            for (Int32 i = 0; i < startTime.Length; i++)
            {
                if (startTime[i] <= queryTime && queryTime <= endTime[i])
                    count++;
            }
            return count;
        }
    }
    public class Solution
    {
        public int BusyStudent(int[] startTime, int[] endTime, int queryTime)
        {
            return AppHelper.BusyStudent(startTime, endTime, queryTime);
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
        }
    }
}
