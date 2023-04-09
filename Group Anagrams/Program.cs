using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Group_Anagrams
{
    public static class Solution
    {
        public static IList<IList<string>> GroupAnagrams(string[] strs)
        {
            ILookup<String, String> Ilkup = strs.ToLookup(key =>
                {
                    var array = key.ToCharArray();
                    Array.Sort(array);
                    return new String(array);
                });
            var result = Ilkup.Select(grouping => (IList<string>)grouping.ToList()).ToList();
            List<List<String>> lst = new List<List<string>>();
            List<string> st = new List<string>();
            foreach (var i in result)
            {
                for (int k = 0; k < i.Count; k++)
                {
                    st.Add(i[k].ToString());
                }
                lst.Add(st);
                st = new List<string>();
            }
            return ((IList<IList<String>>)lst.Cast<IList<String>>().ToList());
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            var t = Solution.GroupAnagrams(new string[] { "eat", "tea", "tan", "ate", "nat", "bat" });
            Console.ReadLine();
        }
    }
}
