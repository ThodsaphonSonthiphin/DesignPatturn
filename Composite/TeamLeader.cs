namespace Composite;

public class TeamLeader : Explorer
{
    protected List<Explorer> ComponentList = new List<Explorer>();

    public override void Add(Explorer component)
    {
        ComponentList.Add(component);
    }

    public override void Remove(Explorer component)
    {
        component.Remove(component);
    }

    public override int Listing()
    {
        return ComponentList.Sum(x => x.Listing());
    }

    public override string ToString()
    {
        return $"listing is {Listing()}";
    }
}