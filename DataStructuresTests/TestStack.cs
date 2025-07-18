

using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace dotnet_dsa.DataStructuresTests;


[TestClass]
public class TestStack
{
    [TestMethod]
    public void Run()
    {
        var stack = new DataStructures.Stack<int>();
        stack.Push(1);
        stack.Push(2);
        stack.Push(3);

        Console.WriteLine("Stack contents:");
        while (stack.Count > 0)
        {
            Console.WriteLine($"{stack.Peek()}");
            stack.Pop();
        }

        // Test popping from an empty stack
        try
        {
            stack.Pop();
        }
        catch (InvalidOperationException ex)
        {
            Console.WriteLine(ex.Message); // Expected: Stack is empty.
        }
    }
}
