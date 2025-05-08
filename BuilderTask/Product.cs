namespace BuilderTask;

public class Product(string type)
{
    private string _type = type;
    private Dictionary<string, string> _parts = new();

    public string this[string key]
    {
        set => _parts[key] = value;
    }

    public void Show()
    {
        Console.WriteLine();
        Console.WriteLine($"Вид транспортного средства: {_type}");
        Console.WriteLine($" Рама: {_parts["frame"]}");
        ;
        Console.WriteLine($" Двигатель: {_parts["engine"]}");
        ;
        Console.WriteLine($" Колеса: {_parts["wheels"]}");
        Console.WriteLine($" Двери: {_parts["doors"]}");
    }
}