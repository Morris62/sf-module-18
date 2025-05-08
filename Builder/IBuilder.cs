namespace Builder;

public interface IBuilder
{
    void FirstStage();
    void SecondStage();
    void ThirdStage();
    Product GetBuilderResult();
}