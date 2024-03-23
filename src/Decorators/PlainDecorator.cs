using System.ComponentModel;
using System.Data.Common;
using StringDecorator.Component;

namespace StringDecorator.Decorators;

public class PlainDecorator : Decorator<string>
{
    public PlainDecorator(IComponent<string> component)
        : base(component) { }

    public override string GetText()
    {
        return "|The Cat Lover|" + base.GetText();
    }
}
