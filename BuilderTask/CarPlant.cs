namespace BuilderTask;

public class CarPlant
{
    public void Construct(Conveyor conveyor)
    {
        conveyor.BuildFrame();
        conveyor.BuildEngine();
        conveyor.BuildWheels();
        conveyor.BuildDoors();
    }
}