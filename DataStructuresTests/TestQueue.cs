
namespace DataStructuresTests;

[TestClass]
public class TestQueue
{
    readonly dotnet_dsa.DataStructures.Queue<int> _queue;

    public TestQueue()
    {
        _queue = new dotnet_dsa.DataStructures.Queue<int>();
        _queue.Enqueue(1);
        _queue.Enqueue(2);
        _queue.Enqueue(3);
    }

    [TestMethod]
    public void Run()
    {

        _queue.Peek();


    }

}