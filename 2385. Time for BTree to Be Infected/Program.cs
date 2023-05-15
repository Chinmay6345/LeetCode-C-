using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//https://leetcode.com/problems/amount-of-time-for-binary-tree-to-be-infected/

namespace _2385.Time_for_BTree_to_Be_Infected
{
    class Program
    {
        static void Main(string[] args)
        {
        }
    }
    public class TreeNode
    {
        public int val;
        public TreeNode left;
        public TreeNode right;
        public TreeNode(int val = 0, TreeNode left = null, TreeNode right = null)
        {
            this.val = val;
            this.left = left;
            this.right = right;
        }
    }
    public class Solution
    {
        int ans = 0;
        public int AmountOfTime(TreeNode root, int start)
        {
            List<List<int>> adj=new List<List<int>>();
            for(int i=0;i< 100001;i++)
            {
                adj.Add(new List<int>());
            }
            bool [] visited=new bool[100001];

            buildGraph(root, adj);        
            bfs(start, adj, visited);
            return ans - 1;
        }
        void buildGraph(TreeNode root, List<List<int>> adj)
        {
            if (root == null)
            {
                return;
            }

            if (root.left==null)
            {
                adj[root.val].Add(root.left.val);
                adj[root.left.val].Add(root.val);
            }

            if (root.right==null)
            {
                adj[root.val].Add(root.right.val);
                adj[root.right.val].Add(root.val);
            }
            buildGraph(root.left, adj);
            buildGraph(root.right, adj);

        }
        void bfs(int start, List<List<int>> adj, bool[] visited)
        {
            Queue<int> q=new Queue<int>();
            q.Enqueue(start);
            while (q.Any())
            {
                int k = q.Count;
                for(int level=0; level < k; level++)
                {
                    int u = q.Dequeue();
                    visited[u] = true;
                    for (int i = 0; i < adj[u].Count; i++)
                    {
                        if (!visited[adj[u][i]])
                            q.Enqueue(adj[u][i]);
                    }
                }
                ans++;
            }
        }
    }
}
