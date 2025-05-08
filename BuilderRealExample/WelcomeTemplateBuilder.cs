using BuilderRealExample.Models;

namespace BuilderRealExample;

public class WelcomeTemplateBuilder : TemplateBuilder
{
    public override void BuildHeader()
    {
        Template.Header = new Header { Text = "Здравствуйте!" };
    }

    public override void BuildBody()
    {
        Template.Body = new Body { Text = "Спасибо за регистрацию в нашем приложении" };
    }

    public override void BuildFooter()
    {
    }
}