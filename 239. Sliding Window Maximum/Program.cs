using System;
using System.Collections.Generic;
using System.Linq;

//https://leetcode.com/problems/sliding-window-maximum/description/

public static class AppHelper
{
    public static List<int> MaxSlidingWindow(int[] arr, int k)
    {
        List<int> lst = new List<int>();
        LinkedList<int> result = new LinkedList<int>();
        int i = 0;
        for (; i < k; ++i)
        {
            while (result.Count > 0 && arr[i] >= arr[result.Last.Value])
            {
                result.RemoveLast();
            }
            result.AddLast(i);
        }
        int n = arr.Length;
        for (; i < n; ++i)
        {
            Console.WriteLine("index and max " + result.First() + " " + arr[result.First()]);
            lst.Add(arr[result.First()]);
            while (result.Count > 0 && result.First() <= i - k)
            {
                result.RemoveFirst();
            }
            while (result.Count > 0 && arr[i] >= arr[result.Last()])
            {
                result.RemoveLast();
            }
            result.AddLast(i);
        }
        lst.Add(arr[result.First()]);
        return lst;
    }

    public static int[] MaxSlidingWindow_Approach2(int[] nums, int k)
    {
        List<int> lst = new List<int>();
        int len = nums.Length;
        int r = 0;
        int l = 0;
        LinkedList<int> q = new LinkedList<int>();
        while (r < len)
        {
            while (q.Count > 0 && nums[q.Last.Value] < nums[r])
            {
                q.RemoveLast();
            }
            q.AddLast(r);

            if (l > q.First.Value)
            {
                q.RemoveFirst();
            }
            if (r + 1 >= k)
            {
                lst.Add(q.First.Value);
                l += 1;
            }
            r += 1;
        }
        return lst.ToArray();
    }

    public static List<int> maxSlidingWindow(int[] nums, int k)
    {
        var res = new List<int>();
        if (nums == null || nums.Length == 0 || k == 0) return res.ToList();

        var deque = new LinkedList<int>();
        for (int r = 0; r < nums.Length; r++)
        {
            // ensure deque has the largest
            while (deque.Count > 0 && nums[r] >= nums[deque.Last()])
            {
                deque.RemoveLast();
            }
            deque.AddLast(r);

            // ensure window
            int left = r - k + 1;

            // if the first one not valid, remove
            if (deque.First() < left)
            {
                deque.RemoveFirst();
            }

            // check anwer here, left valid
            if (left >= 0)
            {
                res.Add(nums[deque.First()]);
            }
        }
        return res.ToList();
    }
}

public class Program
{
    public static void Main(String [] args)
    {
        int[] arr = { 8,7,6,9 };
        int k = 2;
        var lst = AppHelper.MaxSlidingWindow_Approach2(arr, k);
        foreach(int i in lst)
        {
            Console.Write(i + " ");
        }
        Console.ReadLine();
    }
}
