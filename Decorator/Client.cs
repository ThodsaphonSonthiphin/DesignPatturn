namespace Decorator;

public class Client
{
    public void Working(StatOperation statOperation)
    {
        Console.WriteLine(statOperation.Operate());
    }
}