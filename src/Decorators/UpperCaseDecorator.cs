using StringDecorator.Component;

namespace StringDecorator.Decorators;

public class UpperCaseDecorator : Decorator<string>
{
    public UpperCaseDecorator(IComponent<string> component)
        : base(component) { }

    public override string GetText()
    {
        return base.GetText().ToUpper();
    }
}
