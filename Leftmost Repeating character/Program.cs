using System;

namespace Leftmost_Repeating_character
{
    public static class AppHelper
    {
        public static int LeftMost(String str)
        {
            bool[] visited = new bool[256];
            int res = -1;
            for(int i=str.Length-1;i>=0;i--)
            {
                if (visited[str[i]])
                    res = i;
                else
                    visited[str[i]] = true;
            }
            return res;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
           
        }
    }
}
