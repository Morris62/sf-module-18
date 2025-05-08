namespace PrototypeRealExample;

public class Point : ILocation
{
    private double Latitude;
    private double Longitude;

    public Point(double latitude, double longitude)
    {
        Latitude = latitude;
        Longitude = longitude;
    }

    public ILocation Clone()
    {
        return new Point(Latitude, Longitude);
    }

    public void GetInfo()
    {
        Console.WriteLine($"Новая точка на карте с координатами: {Latitude}, {Longitude}");
    }
}