namespace Prototype;

public class ClassTwo(int id) : Prototype(id)
{
    public override Prototype Clone()
    {
        return new ClassTwo(Id);
    }
}