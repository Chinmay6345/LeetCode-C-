using System;

namespace _208._Implement_Trie__Prefix_Tree_
{
    //https://leetcode.com/problems/implement-trie-prefix-tree/
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }
    }

    public class TrieNode
    {
        public TrieNode[] arr;
        public bool IsEndOfWord;

        public TrieNode()
        {
            arr = new TrieNode[26];
            for (int i = 0; i < 26; i++)
            {
                arr[i] = null;
            }
        }

        public bool ContainsKey(char c)
        {
            return arr[c - 'a'] == null;
        }

        public void Put(char c, TrieNode node)
        {
            arr[c - 'a'] = node;
        }
        public TrieNode getWord(char ch)
        {
            return arr[ch - 'a'];
        }
    }


    public class Trie
    {

        public TrieNode root;

        public Trie()
        {
            root = new TrieNode();
        }

        public void Insert(string word)
        {
            TrieNode p = root;
            for (int i = 0; i < word.Length; i++)
            {
                if (p.ContainsKey(word[i]))
                {
                    p.Put(word[i], new TrieNode());
                }
                p = p.getWord(word[i]);
            }
            p.IsEndOfWord = true;
        }

        public bool Search(string word)
        {
            TrieNode p = root;
            for (int i = 0; i < word.Length; i++)
            {
                if (p.ContainsKey(word[i]))
                {
                    return false;
                }
                p = p.getWord(word[i]);
            }
            return p != null && p.IsEndOfWord;
        }

        public bool StartsWith(string prefix)
        {
            TrieNode p = root;
            for (int i = 0; i < prefix.Length; i++)
            {
                if (p.ContainsKey(prefix[i]))
                {
                    return false;
                }
                p = p.getWord(prefix[i]);
            }
            return true;
        }

        public TrieNode delKey(TrieNode root,String key,int i)
        {
            if (root == null)
            {
                return null;
            }
            if(i==key.Length)
            {
                root.IsEndOfWord = false;
                if(IsEmpty(root))
                {
                    root = null;
                }
                return root;
            }
            int index = key[i] - 'a';
            root.arr[index] = delKey(root.arr[index], key, i + 1);
            if(IsEmpty(root) && root.IsEndOfWord==false)
            {
                root = null;
            }
            return root;
        }

        public bool IsEmpty(TrieNode root)
        {
            for(int i=0;i<26;i++)
            {
                if (root.arr[i]!=null)
                {
                    return false;
                }
            }
            return true;
        }
    }

    /**
     * Your Trie object will be instantiated and called as such:
     * Trie obj = new Trie();
     * obj.Insert(word);
     * bool param_2 = obj.Search(word);
     * bool param_3 = obj.StartsWith(prefix);
     */

    /*
     class Solution
{
    //Function to insert string into TRIE.
    public void insert(TrieNode root, string key)
    {
        TrieNode p=root;
        for(int i=0;i<key.Length;i++)
        {
            int index=key[i]-'a';
            if(p.children[index]==null)
            {
                p.children[index]=new TrieNode();
            }
            p=p.children[index];
        }
        p.isLeaf=true;
    }

    //Function to use TRIE data structure and search the given string.
    public bool search(TrieNode root, string key)
    {
        TrieNode p=root;
        for(int i=0;i<key.Length;i++)
        {
            int index=key[i]-'a';
            if(p.children[index]==null)
            {
                return false;
            }
            p=p.children[index];
        }
        return p!=null && p.isLeaf;
    }
}
     */
}
