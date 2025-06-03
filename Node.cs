namespace dotnet_dsa;

public class Node<T>(T? value)
{
    public T? Value = value;
    public Node<T>? Next = null;
    public Node<T>? Previous = null;

}
