


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
        int[] arr = { 1, 3, 1, 2, 0, 5 };
        int k = 3;
        List<int> lst = AppHelper.MaxSlidingWindow(arr, k);
        foreach(int i in lst)
        {
            Console.Write(i + " ");
        }
        Console.ReadLine();
    }
}
