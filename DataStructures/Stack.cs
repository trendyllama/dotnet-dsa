namespace dotnet_dsa.DataStructures;


public class Stack<T>
{
    Node<T>? Top { get; set; }

    public int Count { get; private set; }

    public Node<T>? Current;

    public Stack()
    {
        Top = null;
        Count = 0;
    }

    private void IncrementCount()
    {
        Count++;
    }

    public void Push(T value)
    {
        if (value == null)
        {
            throw new ArgumentNullException(nameof(value), "Cannot push null value onto the stack.");
        }

        Node<T> newNode = new(value);
        if (Top == null)
        {
            Top = newNode;
        }
        else
        {
            newNode.Next = Top;
            Top.Previous = newNode;
            Top = newNode;
        }
        IncrementCount();
    }

    public void Pop()
    {
        if (Top == null)
        {
            throw new InvalidOperationException("Stack is empty.");
        }

        Top = Top.Next;

        if (Top != null)
        {
            Top.Previous = null;
        }

        Count--;
    }

    public T? Peek()
    {
        if (Top == null)
        {
            throw new InvalidOperationException("Stack is empty.");
        }

        return Top.Value;
    }

    public void PeekAndPrint()
    {
        if (Top == null)
        {
            throw new InvalidOperationException("Stack is empty.");
        }

        Console.WriteLine(Top.Value);
    }

    public bool IsEmpty()
    {
        return Count == 0;
    }


    public T? MoveNext()
    {
        if (Current == null)
        {
            throw new InvalidOperationException("No current node to move from.");
        }

        if (Current.Next == null)
        {
            throw new InvalidOperationException("No next node available.");
        }

        Current = Current.Next;
        return Current.Value;
    }

    public IEnumerable<T?> GetEnumerator()
    {
        Node<T>? current = Top;
        while (current != null)
        {
            yield return current.Value;
            current = current.Next;
        }
    }

}