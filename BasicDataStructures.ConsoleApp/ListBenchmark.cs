using BenchmarkDotNet.Attributes;
using System.Security.Cryptography;

namespace BasicDataStructures.ConsoleApp;

public class ListBenchmark
{
    //private const int N = 10000;
    //private readonly byte[] data;

    readonly List<Node> nodeList = new List<Node>();
    readonly LinkedList<Node> nodeLinkedList = new LinkedList<Node>(); 

    public ListBenchmark()
    {
        //data = new byte[N];
        //new Random(42).NextBytes(data);
        
    }

    [Benchmark]
    public void PlainListAdd()
    {
        nodeList.Add(new Node());
    }

    [Benchmark]
    public void LinkedListAdd()
    {
        nodeLinkedList.AddLast(new Node());
    }
}
