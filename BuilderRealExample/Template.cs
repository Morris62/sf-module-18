using System.Text;
using BuilderRealExample.Models;

namespace BuilderRealExample;

public class Template
{
    public Header? Header { get; set; }
    public Body? Body { get; set; }
    public Footer? Footer { get; set; }

    public override string ToString()
    {
        var sb = new StringBuilder();
        if (Header != null)
            sb.AppendLine(Header.Text);
        if (Body != null)
            sb.AppendLine(Body.Text);
        if (Footer != null)
            sb.AppendLine(Footer.Text);
        return sb.ToString();
    }
}