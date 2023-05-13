using System;
using System.Linq;
using System.Collections.Generic;
namespace _71.Simplify_Path
{
    internal class Program
    {
		public static string ShortenPath(string path)
		{
			bool startchar = (path[0] == '/');
			String[] tokensArr = path.Split("/");
			List<string> tokenList = new List<String>(tokensArr);
			List<String> filteredTokens = tokenList.FindAll(g => g.Length > 0 && !g.Equals("."));
			Stack<String> stack = new Stack<String>();
			if (startchar)
			{
				stack.Push("");
			}
			foreach (String token in filteredTokens)
			{
				if (token.Equals(".."))
				{
					if (stack.Count == 0 || stack.Peek().Equals(".."))
					{
						stack.Push(token);
					}
					else if (!stack.Peek().Equals(""))
					{
						stack.Pop();
					}
				}
				else
				{
					stack.Push(token);
				}
			}
			if (stack.Count == 1 && stack.Peek().Equals(""))
			{
				return "/";
			}
			var p = stack.ToArray();
			Array.Reverse(p);
			return String.Join("/", p);
		}
		static void Main(string[] args)
        {
			String str = "/foo/../test/../test/../foo//bar/./baz";
			Console.WriteLine(ShortenPath(str));
			Console.ReadLine();
        }
    }
}
