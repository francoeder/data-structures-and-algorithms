using System.Text.Json;
using data_structures_and_algorithms;

class Program
{
    static void Main()
    {
        var linkedList = new LinkedList(1);
        linkedList.Push(2);
        PrintToConsole(linkedList, "Original Linked List");

        var removedNode = linkedList.Pop();
        PrintToConsole(removedNode!, "Removed Node on first Pop()");
        PrintToConsole(linkedList, "Linked List after first Pop()");

        removedNode = linkedList.Pop();
        PrintToConsole(removedNode!, "Removed Node on second Pop()");
        PrintToConsole(linkedList, "Linked List after second Pop()");

        removedNode = linkedList.Pop();
        PrintToConsole(removedNode!, "Removed Node on third Pop()");
        PrintToConsole(linkedList, "Linked List after third Pop()");
    }

    static void PrintToConsole(object model, string title)
    {
        var output = JsonSerializer.Serialize(model, new JsonSerializerOptions() { WriteIndented = true });
        
        var dividerWithTitle = $"{new string('-', 10)} {title} {new string('-', 10)}";
        var divider = $"{new string('-', dividerWithTitle.Length)}";
        Console.WriteLine($"{dividerWithTitle}\n{output}\n{divider}");
    }
}
