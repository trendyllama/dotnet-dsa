
namespace dotnet_dsa;

class Program
{
    static void Main()
    {
        var linkedList = new DataStructures.LinkedList<int>();

        linkedList.Append(1);
        linkedList.Append(2);
        linkedList.Append(3);

        foreach (var node in linkedList)
        {
            Console.WriteLine(node.Value);
        }

        var stack = new DataStructures.Stack<int>();
        stack.Push(1);
        stack.Push(2);
        stack.Push(3);
        Console.WriteLine("Stack contents:");
        while (stack.Count > 0)
        {
            Console.WriteLine(stack.Pop());
        }

    }
}