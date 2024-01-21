using System.Text.Json;
using data_structures_and_algorithms;

class Program
{
    static void Main()
    {
        var linkedList = new LinkedList(11);
        PrintToConsole(linkedList, "Original Linked List");

        linkedList.Pop();
        PrintToConsole(linkedList, "Linked List after Pop()");

        linkedList.Unshift(3);
        PrintToConsole(linkedList, "Linked List after Unshift(3)");

        linkedList.Unshift(7);
        PrintToConsole(linkedList, "Linked List after Unshift(7)");
    }

    static void PrintToConsole(object model, string title)
    {
        var output = JsonSerializer.Serialize(model, new JsonSerializerOptions() { WriteIndented = true });
        
        var dividerWithTitle = $"{new string('-', 10)} {title} {new string('-', 10)}";
        var divider = $"{new string('-', dividerWithTitle.Length)}";
        Console.WriteLine($"{dividerWithTitle}\n{output}\n{divider}");
    }
}
