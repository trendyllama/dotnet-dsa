/*



*/

class Program
{
    static void Main(string[] args)
    {
        var linkedList = new dotnet_dsa.LinkedList<int>();
        linkedList.Append(1);
        linkedList.Append(2);
        linkedList.Append(3);

        foreach (var node in linkedList)
        {
            Console.WriteLine(node.Value);
        }
    }
}