using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Contiguous_Array
{
    public static class AppHelper
{
    public static Int32 MaxLength(Int32 [] arr,Int32 n)
    {
        for(Int32 i=0;i<n;i++)
        {
            if(arr[i]==0)
                arr[i]=-1;
        }
        Int32 psum=0;
        Int32 res=0;
        Dictionary<Int32, Int32> map = new Dictionary<Int32, Int32>();
        for(Int32 j=0;j<n;j++)
        {
            psum+=arr[j];
            if(psum==0)
            {
                res=j+1;
            }
           if(map.ContainsKey(psum + n) == true)
            {
                if(res < j - map[psum + n])
                 res = j - map[psum + n];
                
            }
            else map.Add(psum + n, j);
        }
        return res;
    }
}

public class Solution {
    public int FindMaxLength(int[] nums) {
        return AppHelper.MaxLength(nums,nums.Length);
    }
}
    class Program
    {
        static void Main(string[] args)
        {
        }
    }
}
