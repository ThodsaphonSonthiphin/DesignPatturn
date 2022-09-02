namespace Decorator;

public abstract class StatDecorator : StatOperation
{
    protected StatOperation _component;

    public StatDecorator(StatOperation component)
    {
        this._component = component;
    }

    public void SetComponent(StatOperation component)
    {
        this._component = component;
    }

    // The Decorator delegates all work to the wrapped component.
    public override string Operate()
    {
        if (this._component != null)
        {
            return this._component.Operate();
        }
        else
        {
            return string.Empty;
        }
    }

   
}