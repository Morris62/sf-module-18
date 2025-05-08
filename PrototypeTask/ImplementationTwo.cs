namespace PrototypeTask;

public class ImplementationOne(int id) : BaseClass(id)
{
    public override BaseClass Clone()
    {
        return new ImplementationOne(Id);
    }

    public override void GetId()
    {
        Console.WriteLine($"Создан объект с {nameof(Id)} {Id}");
    }
}
