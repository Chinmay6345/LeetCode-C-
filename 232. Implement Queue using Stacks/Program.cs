public class MyQueue
{
    Stack<int> s1;
    Stack<int> s2;

    public MyQueue()
    {
        s1 = new Stack<int>();
        s2 = new Stack<int>();
    }

    public void Push(int x)
    {

        while (s1.Count > 0)
        {
            s2.Push(s1.Pop());
            //s1.Pop();
        }

        // Push item into s1
        s1.Push(x);

        // Push everything back to s1
        while (s2.Count > 0)
        {
            s1.Push(s2.Pop());
            //s2.Pop();
        }

    }



    public int Pop()
    {

        return s1.Pop();
    }

    public int Peek()
    {

        if (s1.Count > 0)
        {
            return s1.Peek();
        }
        return -1;
    }

    public bool Empty()
    {
        if (s1.Count == 0 && s2.Count == 0)
            return true;

        return false;
    }
}


public class Program
{
    public static void Main(string[] args)
    {
        Console.WriteLine();
    }
}
/**
 * Your MyQueue object will be instantiated and called as such:
 * MyQueue obj = new MyQueue();
 * obj.Push(x);
 * int param_2 = obj.Pop();
 * int param_3 = obj.Peek();
 * bool param_4 = obj.Empty();
 */