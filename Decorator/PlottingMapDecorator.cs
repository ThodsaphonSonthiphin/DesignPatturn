namespace Decorator;

public class PlottingMapDecorator : StatDecorator
{
    public PlottingMapDecorator(StatOperation component) : base(component)
    {
    }

    public override string Operate()
    {
        var result = base.Operate();

        result += "\n Plotting map";
        return result;
    }
}