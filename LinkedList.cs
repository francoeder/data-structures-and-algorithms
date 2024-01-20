namespace data_structures_and_algorithms;

public class LinkedList
{
    public Node? Head { get; set; }
    public Node? Tail { get; set; }
    public int Length { get; set; }

    public LinkedList(int value)
    {
        var newNode = new Node(value);
        Head = newNode;
        Tail = newNode;
        Length = 1;
    }

    public Node Push(int value)
    {
        var newNode = new Node(value);
        if (Head == null)
        {
            Head = newNode;
            Tail = newNode;
        }
        else
        {
            Tail!.Next = newNode;
            Tail = newNode;
        }
        Length ++;
        return newNode;
    }

    public Node? Pop()
    {
        if (Head == null)
            return null;

        var pre = Head;
        var temp = Head;

        while (temp.Next != null)
        {
            pre = temp;
            temp = temp.Next;
        }

        Tail = pre;
        Tail.Next = null;
        Length--;

        if (Length == 0)
        {
            Head = null;
            Tail = null;
        }

        return temp;
    }
}
