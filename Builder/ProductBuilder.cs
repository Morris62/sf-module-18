namespace Builder;

public class ProductBuilder : IBuilder
{
    Product product = new();

    public void FirstStage()
    {
        product.Add("Part One");
    }

    public void SecondStage()
    {
        product.Add("Part Two");
    }

    public void ThirdStage()
    {
        product.Add("Part Three");
    }

    public Product GetBuilderResult()
    {
        return product;
    }
}