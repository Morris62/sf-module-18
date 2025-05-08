namespace BuilderRealExample;

public abstract class TemplateBuilder
{
    public Template Template { get; private set; }

    public void CreateTemplate()
    {
        Template = new Template();
    }

    public abstract void BuildHeader();
    public abstract void BuildBody();
    public abstract void BuildFooter();
}