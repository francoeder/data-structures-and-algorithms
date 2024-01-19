namespace data_structures_and_algorithms;

public class Node
{
    public int Value { get; set; }
    public Node? Next { get; set; }

    public Node(int value)
    {
        Value = value;
    }
}
