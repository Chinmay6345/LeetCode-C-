using System;

namespace _98._Validate_Binary_Search_Tree
{
    //https://leetcode.com/problems/validate-binary-search-tree/
     public class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine();
        }
    }

    public class Node
    {
        public int data;
        public Node left;
        public Node right;
        public Node(int val = 0, Node left = null, Node right = null)
        {
            data = val;
            this.left = left;
            this.right = right;
        }

    }
        public class Solution
        {
            public long prev = long.MinValue;

            public bool IsBST(Node root,int min,int max)
            {
                if (root == null)
                    return true;
                return ( root.data > min && root.data < max && IsBST(root,min,root.data) && IsBST(root,root.data,max));
            }

            public bool IsValidBST(Node root)
            {
                if (root == null)
                {
                    return true;
                }
                if (!IsValidBST(root.left))
                {
                    return false;
                }
                if (root.data <= prev)
                {
                    return false;
                }
                prev = root.data;
                return IsValidBST(root.right);
            }
        }
    }
