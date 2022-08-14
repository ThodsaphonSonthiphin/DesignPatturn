namespace AbstractFactory;

public class GamingFactory:IFactory
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