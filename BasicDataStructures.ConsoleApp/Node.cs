namespace BasicDataStructures.ConsoleApp;

internal class Node
{
    public int Id { get; set; }

    public override string ToString()
    {
        return Id.ToString();
    }
}

internal class NodeFactory
{
    int id = 1;

    public Node CreateNode()
    {
        return new Node
        {
            Id = id++
        };
    }
}


internal class NodeFactory<T> where T : Node, new()
{
    int id = 1;

    public T CreateNode()
    {
        return new T
        {
            Id = id++
        };
    }
}

internal class LinkedNode : Node
{
    public LinkedNode? Link { get; set; } = null;
}