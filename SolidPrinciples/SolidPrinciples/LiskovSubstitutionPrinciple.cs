namespace SolidPrinciples;

public class Apple
{
    public virtual string GetColor()
    {
        return "Red";
    }
}

// class orange modify GetColor of Apple
public class Orange : Apple
{
    public override string GetColor()
    {
        return "Orange";
    }
}

// we can refactor to follow LSP
public interface IFruit
{
    string GetColor();
}
public class AppleV1 : IFruit
{
    public string GetColor()
    {
        return "Red";
    }
}
public class OrangeV1 : IFruit
{
    public string GetColor()
    {
        return "Orange";
    }
}