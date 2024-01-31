using System.Text.Json;
using data_structures_and_algorithms;

class Program
{
    static void Main()
    {
        var linkedList = new LinkedList(11);
        linkedList.Push(3);
        linkedList.Push(23);
        linkedList.Push(7);
        PrintToConsole(linkedList, "Original Linked List");

        var index = 2;
        var removedNode = linkedList.Remove(index);
        PrintToConsole(removedNode!, $"Removed Node at index {index}");
        
        PrintToConsole(linkedList, "Linked List after insert");
    }

    static void PrintToConsole(object model, string title)
    {
        var output = JsonSerializer.Serialize(model, new JsonSerializerOptions() { WriteIndented = true });
        
        var dividerWithTitle = $"{new string('-', 10)} {title} {new string('-', 10)}";
        var divider = $"{new string('-', dividerWithTitle.Length)}";
        Console.WriteLine($"{dividerWithTitle}\n{output}\n{divider}");
    }
}
