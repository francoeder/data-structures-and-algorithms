using System.Text.Json;
using data_structures_and_algorithms;

class Program
{
    static void Main()
    {
        var linkedList = new LinkedList(7);
        linkedList.Push(4);

        PrintToConsole(linkedList);
    }

    static void PrintToConsole(object model)
    {
        var output = JsonSerializer.Serialize(model, new JsonSerializerOptions() { WriteIndented = true });
        Console.WriteLine(output);
    }
}
