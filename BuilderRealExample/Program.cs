using BuilderRealExample;

var templateEngine = new TemplateEngine();

TemplateBuilder builder = new WelcomeTemplateBuilder();
var greetingTemplate = templateEngine.GenerateTemplate(builder);
Console.WriteLine(greetingTemplate);

builder = new OrderTemplateBuilder();
var orderTemplate = templateEngine.GenerateTemplate(builder);
Console.WriteLine(orderTemplate);