namespace BuilderRealExample;

public class TemplateEngine
{
    public Template GenerateTemplate(TemplateBuilder templateBuilder)
    {
        templateBuilder.CreateTemplate();

        templateBuilder.BuildHeader();
        templateBuilder.BuildBody();
        templateBuilder.BuildFooter();

        return templateBuilder.Template;
    }
}