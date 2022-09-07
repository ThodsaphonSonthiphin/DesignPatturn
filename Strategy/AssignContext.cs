namespace Strategy;

public class AssignContext
{
    public  IStrategy Strategy { get; set; }

    public AssignContext(IStrategy strategy)
    {
        Strategy = strategy;
    }

    public string SaveChange()
    {
        return this.Strategy.Save();
    }


}