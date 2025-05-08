namespace Builder;

public class BuildManager(IBuilder builder)
{
    private IBuilder _builder = builder;

    public void StartBuildingProcess()
    {
        _builder.FirstStage();
        _builder.SecondStage();
        _builder.ThirdStage();
    }
}