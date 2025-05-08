namespace BuilderTask;

public abstract class Conveyor
{
    protected Product _product;
    public Product Product => _product;

    public abstract void BuildFrame();
    public abstract void BuildEngine();
    public abstract void BuildWheels();
    public abstract void BuildDoors();
}