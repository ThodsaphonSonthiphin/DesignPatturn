namespace Composite;

public class Officer : Explorer
{
    public override int Listing()
    {
        return 10;
    }

    public override bool IsComposite()
    {
        return false;
    }
}