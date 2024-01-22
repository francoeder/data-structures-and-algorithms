using System.Text.Json;
using data_structures_and_algorithms;

class Program
{
    static void Main()
    {
        var linkedList = new LinkedList(1);
        linkedList.Push(2);
        linkedList.Push(3);
        linkedList.Push(4);
        linkedList.Push(5);
        PrintToConsole(linkedList, "Original Linked List");

        var nodeObtained = linkedList.Get(3);
        PrintToConsole(nodeObtained!, $"Node obtained through index {3}");

        var nullNode = linkedList.Get(-1);
        PrintToConsole(nullNode!, $"Node obtained through index {-1}");

        nullNode = linkedList.Get(45);
        PrintToConsole(nullNode!, $"Node obtained through index {45}");
    }

    static void PrintToConsole(object model, string title)
    {
        var output = JsonSerializer.Serialize(model, new JsonSerializerOptions() { WriteIndented = true });
        
        var dividerWithTitle = $"{new string('-', 10)} {title} {new string('-', 10)}";
        var divider = $"{new string('-', dividerWithTitle.Length)}";
        Console.WriteLine($"{dividerWithTitle}\n{output}\n{divider}");
    }
}
