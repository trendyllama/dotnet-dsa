
using dotnet_dsa.DataStructures;


class Queue<T>
{
    public Node<T>? head;
    public Node<T>? tail;
    private int size;
    public Node<T>? Current;

    Queue()
    {
        head = null;
        tail = null;
        size = 0;
    }


    public void IncrementSize()
    {
        size++;
    }

    public bool IsEmpty()
    {
        if (head == null)
        {
            throw new InvalidOperationException("Queue is empty.");
        }

        return size == 0;
    }

    public void Enqueue(T value)
    {
        if (value == null)
        {
            throw new ArgumentNullException(nameof(value), "Cannot enqueue null value.");
        }

        Node<T> newNode = new(value);
        if (tail == null)
        {
            head = newNode;
            tail = newNode;
        }
        else
        {
            tail.Next = newNode;
            tail = newNode;
        }
        IncrementSize();
    }

    public void Dequeue()
    {
        if (head == null)
        {
            throw new InvalidOperationException("Queue is empty.");
        }

        head = head.Next;

        if (head == null)
        {
            tail = null;
        }

        size--;
    }

    public T? Peek()
    {
        if (head == null)
        {
            throw new InvalidOperationException("Queue is empty.");
        }

        return head.Value;
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
        Node<T>? current = head;
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