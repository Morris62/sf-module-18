using BuilderRealExample.Models;

namespace BuilderRealExample;

public class OrderTemplateBuilder : TemplateBuilder
{
    public override void BuildHeader()
    {
        Template.Header = new Header { Text = "Здравствуйте, спасибо за заказ!" };
    }

    public override void BuildBody()
    {
        Template.Body = new Body { Text = "Ваш номер заказа - 123" };
    }

    public override void BuildFooter()
    {
        Template.Footer = new Footer { Text = "ООО \"Всё что пожелаете\", wishes@yandex.ru" };
    }
}