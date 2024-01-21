using System.Text.Json;
using data_structures_and_algorithms;

class Program
{
    static void Main()
    {
        var linkedList = new LinkedList(1);
        linkedList.Push(3);
        PrintToConsole(linkedList, "Original Linked List");

        var firstNode = linkedList.Shift();
        PrintToConsole(firstNode!, "First shifted node");
        PrintToConsole(linkedList, "Linked List after first Shift()");

        var secondNode = linkedList.Shift();
        PrintToConsole(secondNode!, "Second shifted node");
        PrintToConsole(linkedList, "Linked List after second Shift()");

        var thirdNode = linkedList.Shift();
        PrintToConsole(thirdNode!, "Third shifted node");
        PrintToConsole(linkedList, "Linked List after third Shift()");
    }

    static void PrintToConsole(object model, string title)
    {
        var output = JsonSerializer.Serialize(model, new JsonSerializerOptions() { WriteIndented = true });
        
        var dividerWithTitle = $"{new string('-', 10)} {title} {new string('-', 10)}";
        var divider = $"{new string('-', dividerWithTitle.Length)}";
        Console.WriteLine($"{dividerWithTitle}\n{output}\n{divider}");
    }
}
