
namespace DataStructuresTests;

[TestClass]

public class TestStack
{

    readonly dotnet_dsa.DataStructures.Stack<int> _stack;

    public TestStack()
    {
        // Initialize any required resources here

        _stack = new dotnet_dsa.DataStructures.Stack<int>();
        _stack.Push(1);
        _stack.Push(2);
        _stack.Push(3);

    }

    [TestMethod]
    public void Run()
    {

        Console.WriteLine("Stack contents:");
        while (_stack.Count > 0)
        {
            Console.WriteLine($"{_stack.Peek()}");
            _stack.Pop();
        }

        // Test popping from an empty stack
        try
        {
            _stack.Pop();
        }
        catch (InvalidOperationException ex)
        {
            Console.WriteLine(ex.Message); // Expected: Stack is empty.
        }
    }
}