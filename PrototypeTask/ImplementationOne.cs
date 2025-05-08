namespace PrototypeTask;

public class ImplementationOne(int id) : BaseClass(id)
{
    public override BaseClass Clone()
    {
        return new ImplementationOne(Id);
    }
}