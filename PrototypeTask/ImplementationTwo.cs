namespace PrototypeTask;

public class ImplementationTwo(int id) : BaseClass(id)
{
    public override BaseClass Clone()
    {
        return new ImplementationTwo(Id);
    }
}