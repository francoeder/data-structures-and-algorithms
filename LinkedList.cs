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

    public Node Unshift(int value)
    {
        var newNode = new Node(value);

        if (Head == null)
        {
            Head = newNode;
            Tail = newNode;
        }
        else
        {
            newNode.Next = Head;
            Head = newNode;
        }

        Length++;

        return newNode;
    }

    public Node? Shift()
    {
        if (Head == null) return null;
        
        var temp = Head;
        Head = Head.Next;
        temp!.Next = null;

        Length--;

        if (Length == 0)
            Tail = null;

        return temp;
    }

    public Node? Get(int index)
    {
        if (index < 0 || index >= Length) return null;

        var temp = Head;
        for (int i = 0; i < index; i++)
        {
            temp = temp!.Next;
        }

        return temp;
    }

    public bool Set(int index, int value)
    {
        var temp = Get(index);
        
        if (temp == null)
            return false;
        
        temp.Value = value;
        return true;
    }

    public Node? Insert(int index, int value)
    {
        if (index == 0) return Unshift(value);
        if (index == Length) return Push(value);
        if (index < 0 || index > Length) return null;

        var newNode = new Node(value);
        var temp = Get(index - 1);

        newNode.Next = temp!.Next;
        temp.Next = newNode;

        return newNode;
    }
}
