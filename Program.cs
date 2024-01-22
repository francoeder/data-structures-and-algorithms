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

        var nodeChanged = linkedList.Set(2, 21);
        PrintToConsole(nodeChanged!, $"Was there any success in changing the node through index {2}?");

        var nullNode = linkedList.Set(-1, 7);
        PrintToConsole(nullNode!, $"Was there any success in changing the node through index {-1}?");

        nullNode = linkedList.Set(45, 7);
        PrintToConsole(nullNode!, $"Was there any success in changing the node through index {45}?");

        PrintToConsole(linkedList, "Linked List after changes");
    }

    static void PrintToConsole(object model, string title)
    {
        var output = JsonSerializer.Serialize(model, new JsonSerializerOptions() { WriteIndented = true });
        
        var dividerWithTitle = $"{new string('-', 10)} {title} {new string('-', 10)}";
        var divider = $"{new string('-', dividerWithTitle.Length)}";
        Console.WriteLine($"{dividerWithTitle}\n{output}\n{divider}");
    }
}
