// See https://aka.ms/new-console-template for more information





public static class AppHelper
{
    public static Boolean IsMatching(Char curr_char, Char stckTop)
    {
        return

        (
           (curr_char == '(' && stckTop == ')') ||
           (curr_char == '{' && stckTop == '}') ||
           (curr_char == '[' && stckTop == ']')
        );
    }

    public static Boolean IsValid(String s)
    {
        Stack<Char> stck = new Stack<Char>();
        foreach (Char chr in s)
        {
            if (chr == '(' || chr == '{' || chr == '[')
            {
                stck.Push(chr);
            }
            else
            {
                if (stck.Count() == 0)
                {
                    return false;
                }
                else
                {
                    if (IsMatching(stck.Peek(),chr) == false)
                        return false;
                }
                stck.Pop();
            }
        }
        return (stck.Count() == 0);
    }
}


public class Solution
{
    public bool IsValid(string s)
    {
        return AppHelper.IsValid("()");
    }
}


public class Program
{ 
    public static void Main(String [] args)
    {
        bool p= AppHelper.IsValid("()");
        Console.ReadLine();
    }
}

