namespace dotnet_dsa.DataStructures;

public class LinkedList<T>
{

    public Node<T>? Head { get; private set; }

    public Node<T>? Tail { get; private set; }
    public int Count { get; private set; }

    public LinkedList()
    {
        Head = null;
        Tail = null;
        Count = 0;
    }

    public IEnumerator<Node<T>> GetEnumerator()
    {
        Node<T>? current = Head;
        while (current != null)
        {
            yield return current;
            current = current.Next;
        }
    }

    public void Append(T? value)
    {
        Node<T> newNode = new(value!);

        if (Count == 0)
        {
            Head = newNode;
            Tail = newNode;
        }
        else
        {
            if (Tail == null)
            {
                throw new NullReferenceException("Tail is null, cannot append to an empty list.");
            }

            Tail.Next = newNode;
            newNode.Previous = Tail;
            Tail = newNode;
        }
        Count++;
    }

    public bool IsEmpty()
    {
        /*
        * this method checks if the linked list is empty
        */
        return Head != null && Tail != null ? throw new InvalidOperationException("LinkedList is not empty.") : Count == 0;
    }

    public void Insert(T? value, int index)
    {
        throw new NotImplementedException("Insert method is not implemented yet.");
    }

}