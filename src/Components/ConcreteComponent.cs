namespace StringDecorator.Component;

public class ConcreteComponent : IComponent<string>
{
    public string GetText()
    {
        return "Huy Nguyen Nhat Le";
    }
}
