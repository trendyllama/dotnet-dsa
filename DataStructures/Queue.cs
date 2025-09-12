
namespace dotnet_dsa.DataStructures;


public class Queue<T>
{
    public Node<T>? Head;
    public Node<T>? Tail;
    private int _size;
    public Node<T>? Current;

    public Queue()
    {
        Head = null;
        Tail = null;
        _size = 0;
    }


    public void IncrementSize()
    {
        _size++;
    }

    public bool IsEmpty()
    {
        if (Head == null)
        {
            throw new InvalidOperationException("Queue is empty.");
        }

        return _size == 0;
    }

    public void Enqueue(T value)
    {
        if (value == null)
        {
            throw new ArgumentNullException(nameof(value), "Cannot enqueue null value.");
        }

        Node<T> newNode = new(value);
        if (Tail == null)
        {
            Head = newNode;
            Tail = newNode;
        }
        else
        {
            Tail.Next = newNode;
            Tail = newNode;
        }
        IncrementSize();
    }

    public void Dequeue()
    {
        if (Head == null)
        {
            throw new InvalidOperationException("Queue is empty.");
        }

        Head = Head.Next;

        if (Head == null)
        {
            Tail = null;
        }

        _size--;
    }

    public T? Peek()
    {
        if (Head == null)
        {
            throw new InvalidOperationException("Queue is empty.");
        }

        return Head.Value;
    }

    public Node<T>? MoveNext()
    {
        if (Current == null)
        {
            throw new InvalidOperationException("No current node to move next from.");
        }

        Current = Current.Next;
        return Current;
    }

    public IEnumerable<T> GetEnumerator()
    {
        Node<T>? current = Head;
        while (current != null)
        {
            if (current.Value == null)
            {
                throw new InvalidOperationException("Current node value is null.");
            }

            yield return current.Value;
            current = current.Next;
        }

    }


}