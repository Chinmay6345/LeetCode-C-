using System;

namespace _230._Kth_Smallest_Element_in_a_BST
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Node node = new Node(4);
            node.left = new Node(2);
            node.right = new Node(9);
           // Node y=AppHelper.kLarge(node, 2);
        }
    }
    public class Node
    {
        public int data;
        public Node left;
        public Node right;
        public int lCount;
        public Node(int val = 0, Node left = null, Node right = null)
        {
            data = val;
            this.left = left;
            this.right = right;
            this.lCount = 0;
        }
    }
    public class Solution
    {

        public void kthsmallest(Node root, int k, ref int count, ref int element)
        {
            if (root != null)
            {
                kthsmallest(root.left, k, ref count, ref element);
                count++;
                if (count == k)
                {
                    element = root.data;
                    return;
                }
                kthsmallest(root.right, k, ref count, ref element);
            }
        }

        public int KthSmallest(Node root, int k)
        {
            int count = 0;
            int element = 0;
            kthsmallest(root, k, ref count, ref element);
            return element;
        }
    }

    public static class AppHelper
    {
        public static void large(Node root, int k)
        {
            if (root != null)
            {
                large(root.right, k);
                p++;
                if (p == k)
                {
                    res = root.data;
                    return;
                }
                large(root.left, k);
            }
        }
        public static int p;
        public static int res;

        //public static Node kLarge(Node root,int k)
        //{
        //    if (root == null)
        //        return null;
        //    int count = root.lCount + 1;
        //    if (count ==k)
        //    {
        //        return root;
        //    }
        //    if (count > k)
        //        return kLarge(root.right, k - count);
        //    return kLarge(root.left, k);
        //}
  
    }
}
