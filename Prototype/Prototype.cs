namespace Prototype;

public abstract class Prototype(int id)
{
    protected int Id = id;
    public abstract Prototype Clone();
}