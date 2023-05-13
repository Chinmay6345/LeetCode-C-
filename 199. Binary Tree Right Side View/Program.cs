using System;
using System.Collections.Generic;
using System.Linq;

namespace _199._Binary_Tree_Right_Side_View
{
    //https://leetcode.com/problems/binary-tree-right-side-view/
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
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


        public int maxLevel = 0;
        public List<int> lst;

        public Solution()
        {
            lst = new List<int>();
        }

        public void RightView(TreeNode root, int level)
        {
            if (root == null)
                return;
            if (maxLevel < level)
            {
                lst.Add(root.val);
                maxLevel = level;
            }
            RightView(root.right, level + 1);
            RightView(root.left, level + 1);
        }

        public void RightViewItr(TreeNode root)
        {
            if (root == null)
                return;
            Queue<TreeNode> q = new Queue<TreeNode>();
            q.Enqueue(root);
            while (q.Any())
            {
                int count = q.Count();
                for (int i = 0; i < count; i++)
                {
                    TreeNode curr = q.Dequeue();
                    //Console.Write(curr.val + " ");
                    if (i == 0 && curr != null)
                    {
                        lst.Add(curr.val);
                    }
                    if (curr.right != null)
                        q.Enqueue(curr.right);
                    if (curr.left != null)
                        q.Enqueue(curr.left);
                }
            }
        }


        public IList<int> RightSideView(TreeNode root)
        {
            RightView(root, 1);
            return lst;
        }
    }
}
