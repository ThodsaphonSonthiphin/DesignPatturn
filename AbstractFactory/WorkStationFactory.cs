namespace AbstractFactory;

public class WorkStationFactory : IFactory
{
    public INoteBook CreateNotebook()
    {
        return new GamingNotebook();
    }

    public IHeadSet CreateHeadSet()
    {
        return new GamingHeadSet();
    }
}