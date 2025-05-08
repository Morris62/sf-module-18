namespace Builder;

public class Product
{
    private List<object> parts = new();

    public void Add(object part)
    {
        parts.Add(part);
    }
}