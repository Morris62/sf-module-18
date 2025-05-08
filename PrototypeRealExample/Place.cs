namespace PrototypeRealExample;

public class Place : ILocation
{
    private string Address;

    public Place(string address)
    {
        Address = address;
    }

    public ILocation Clone()
    {
        return new Place(Address);
    }

    public void GetInfo()
    {
        Console.WriteLine($"Новый объект по адресу: {Address}");
    }
}