namespace Prototype;

public class ClassOne(int id) : Prototype(id)
{
    public override Prototype Clone()
    {
        return new ClassOne(Id);
    }
}