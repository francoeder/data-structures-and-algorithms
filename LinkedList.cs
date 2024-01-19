namespace data_structures_and_algorithms;

public class LinkedList
{
    public Node Head { get; set; }
    public Node Tail { get; set; }
    public int Length { get; set; }

    public LinkedList(int value)
    {
        var newNode = new Node(value);
        Head = newNode;
        Tail = newNode;
        Length = 1;
    }
}
