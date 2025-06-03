﻿namespace dotnet_dsa;

public class LinkedList<T>
{

    public Node<T>? Head { get; private set; }

    public Node<T>? Tail { get; private set; }
    public int Count { get; private set; }

}
