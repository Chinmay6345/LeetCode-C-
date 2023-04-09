using System;
using System.Text;
using System.Collections.Generic;
namespace _76._Minimum_Window_Substring
{
    //https://leetcode.com/problems/minimum-window-substring/description/
    class Program
    {
        static void Main(string[] args)
        {
            string s = "ADOBECODEBANC";
            string t = "ABC";
            Console.WriteLine(AppHelper.MinWindow(s, t));
            Console.WriteLine("Hello World!");
        }
    }

    public static class AppHelper
    {
        public static string MinWindow(string s, string t)
        {
            int need = t.Length;
            int[] resLen = { 0, 0 };
            int res = Int32.MaxValue;
            if (s.Length <need)
            {
                return String.Empty;
            }
            Dictionary<Char, int> window = new Dictionary<char, int>();
            Dictionary<Char, int> T_kvp = new Dictionary<char, int>();
            for(int i=0;i<need;i++)
            {
                if (!T_kvp.ContainsKey(t[i]))
                {
                    T_kvp.Add(t[i], 1);
                }
                else
                {
                    T_kvp[t[i]]++;
                }
            }
            int have = 0;
            int left = 0;
            for(int right=0; right < s.Length; right++)
            {               
                if(!window.ContainsKey(s[right]))
                {
                    window.Add(s[right], 1);
                }
                else
                {
                    window[s[right]]++;
                }
                if((T_kvp.ContainsKey(s[right])) && (T_kvp[s[right]]==window[s[right]]))
                {
                    have += 1;
                }
                if(have==need)
                {
                    while(have==need)
                    {
                        if(right-left+1 <res)
                        {
                            res = right - left + 1;
                            resLen[0] = left;
                            resLen[1] = right;
                        }
                        window[s[left]]--;
                        if(T_kvp.ContainsKey(s[left]) && window[s[left]] < T_kvp[s[left]])
                        {
                            have -= 1;
                        }
                        left++;
                    }
                }
            }
            StringBuilder builder = new StringBuilder();
            string substring = s.Substring(resLen[0], resLen[1]- resLen[0]+1);
            for(int i=resLen[0];i<resLen[1]+1;i++)
            {
                builder.Append(s[i]);
            }
            return res != int.MaxValue ? builder.ToString() : String.Empty;
        }
    }
}
