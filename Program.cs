using System.Text.Json;
using data_structures_and_algorithms;

class Program
{
    static void Main()
    {
        var linkedList = new LinkedList(2);
        PrintToConsole(linkedList, "Original Linked List");

        var insertedNode = linkedList.Insert(0, 0);
        PrintToConsole(insertedNode!, $"Inserted Node at index {0}");

        insertedNode = linkedList.Insert(1, 1);
        PrintToConsole(insertedNode!, $"Inserted Node at index {1}");

        insertedNode = linkedList.Insert(2, 3);
        PrintToConsole(insertedNode!, $"Inserted Node at index {3}");

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
