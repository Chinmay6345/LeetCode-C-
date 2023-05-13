using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//https://leetcode.com/problems/accounts-merge/

namespace _721.Accounts_Merge
{
    class Program
    {
        static void Main(string[] args)
        {
            string[][] accounts = new string[][]{ new string[] { "John", "johnsmith@mail.com", "john_newyork@mail.com" },
                                                  new string[] {"John","johnsmith@mail.com","john00@mail.com"},
                                                  new string[] {"Mary","mary@mail.com"},
                                                  new string[] {"John","johnnybravo@mail.com"} };
            var output = new Solution().AccountsMerge(accounts);
            Console.ReadLine();
        }
    }
    public class Solution
    {
        public IList<IList<string>> AccountsMerge(IList<IList<string>> accounts)
        {
            int n = accounts.Count;
            UnionFind unionFind = new UnionFind(n);
            Dictionary<string, int> emailToAccount = new Dictionary<string, int>();
            for (int i = 0; i < n; i++)
            {
                int accountSize = accounts[i].Count();

                for (int j = 1; j < accountSize; j++)
                {
                    String email = accounts[i][j];
                    String accountName = accounts[i][0];

                    // If this is the first time seeing this email then
                    // assign component group as the account index
                    if (!emailToAccount.ContainsKey(email))
                    {
                        emailToAccount.Add(email, i);
                    }
                    else
                    {
                        // If we have seen this email before then union this
                        // group with the previous group of the email
                        unionFind.Union(i, emailToAccount[email]);
                    }
                }
            }
            Dictionary<int, List<String>> components = new Dictionary<int, List<String>>();
            foreach (String email in emailToAccount.Keys)
            {
                int group = emailToAccount[email];
                int leader = unionFind.Find(group);

                if (!components.ContainsKey(leader))
                {
                    components.Add(leader, new List<String>());
                }

                components[leader].Add(email);
            }
            List<List<String>> mergedAccounts = new List<List<String>>();
            foreach (int group in components.Keys)
            {
                var component = components[group];
                component.Sort(StringComparer.Ordinal);
                component.Insert(0, accounts[group][0]);
                mergedAccounts.Add(component);
            }

            return ((IList<IList<String>>)mergedAccounts.Cast<IList<String>>().ToList());
        }
    }

    public class UnionFind
    {
        int [] representative;
        int [] size;

        public UnionFind(int sz)
        {
            representative = new int[sz];
            size = new int[sz];

            for (int i = 0; i < sz; ++i)
            {
                // Initially each group is its own representative
                representative[i] = i;
                // Intialize the size of all groups to 1
                size[i] = 1;
            }
        }

        // Finds the representative of group x
        public int Find(int x)
        {
            if (x == representative[x])
            {
                return x;
            }

            // This is path compression
            return representative[x] = Find(representative[x]);
        }

        // Unite the group that contains "a" with the group that contains "b"
        public void Union(int a, int b)
        {
            int representativeA = Find(a);
            int representativeB = Find(b);

            // If nodes a and b already belong to the same group, do nothing.
            if (representativeA == representativeB)
            {
                return;
            }

            // Union by size: point the representative of the smaller
            // group to the representative of the larger group.
            if (size[representativeA] >= size[representativeB])
            {
                size[representativeA] += size[representativeB];
                representative[representativeB] = representativeA;
            }
            else
            {
                size[representativeB] += size[representativeA];
                representative[representativeA] = representativeB;
            }
        }
    }

}
