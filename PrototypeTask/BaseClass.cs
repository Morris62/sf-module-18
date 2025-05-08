namespace PrototypeTask;

public abstract class BaseClass(int id)
{
    protected int Id = id;

    public abstract BaseClass Clone();

    public void GetId()
    {
        Console.WriteLine($"Создан объект с {nameof(Id)} {Id}");
    }
}