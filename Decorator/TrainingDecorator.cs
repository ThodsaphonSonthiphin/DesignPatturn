namespace Decorator;

public class TrainingDecorator : StatDecorator
{
    public TrainingDecorator(StatOperation component) : base(component)
    {
    }

    public override string Operate()
    {
        var result = base.Operate();

        result += "\n Training";
        return result;
    }
}