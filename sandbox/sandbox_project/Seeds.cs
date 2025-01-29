public class SeedQueue
{
    public static void Run()
    {
        var queue = new SeedQueue();
        queue.Enqueue("pumpkins");
        queue.Enqueue("tomatoes");
        queue.Enqueue("pototoes");
        queue.Enqueue("avocados");

        var value = queue.Dequeue();
        Console.WriteLine(value);
        value = queue.Dequeue();
        Console.WriteLine(value);
        value = queue.Dequeue();
        Console.WriteLine(value);
        value = queue.Dequeue();
        Console.WriteLine(value);
    }
    private readonly List<string> _queue = new();

    private void Enqueue(string value)
    {

        _queue.Add(value);
    }

    private string Dequeue()
    {
        if (_queue.Count <= 0)
            throw new IndexOutOfRangeException();

        var value = _queue[0];
        _queue.RemoveAt(0);
        return value;

        
    }

}