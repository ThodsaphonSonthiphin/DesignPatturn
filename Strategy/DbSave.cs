namespace Strategy;

public class DbSave : IStrategy
{
    public string Save()
    {
        return "save to Db";
    }
}