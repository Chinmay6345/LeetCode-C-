
public class Stack
{
    // Two inbuilt queues
    public Queue<int> q1 = new Queue<int>();
    public Queue<int> q2 = new Queue<int>();

    // To maintain current number of
    // elements
    public int curr_size;

    public Stack()
    {
        curr_size = 0;
    }

    public void push(int x)
    {
        curr_size++;

        // Push x first in empty q2
        q2.Enqueue(x);

        // Push all the remaining
        // elements in q1 to q2.
        while (q1.Count > 0)
        {
            q2.Enqueue(q1.Peek());
            q1.Dequeue();
        }

        // swap the names of two queues
        Queue<int> q = q1;
        q1 = q2;
        q2 = q;
    }

    public void pop()
    {

        // if no elements are there in q1
        if (q1.Count == 0)
            return;
        q1.Dequeue();
        curr_size--;
    }

    public int top()
    {
        if (q1.Count == 0)
            return -1;
        return q1.Peek();
    }

    public int size()
    {
        return curr_size;
    }
};

// Driver code
public class Program
{


    public static void Main(String[] args)
    {
        Stack s = new Stack();
        s.push(1);
        s.push(2);
        s.push(3);
        Console.WriteLine("current size: " + s.size());
        Console.WriteLine(s.top());
        s.pop();
        Console.WriteLine(s.top());
        s.pop();
        Console.WriteLine(s.top());
        Console.WriteLine("current size: " + s.size());
        Console.ReadLine();
    }
}

