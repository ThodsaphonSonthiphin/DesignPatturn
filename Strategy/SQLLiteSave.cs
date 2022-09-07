namespace Strategy;

public class SQLLiteSave : IStrategy
{
    public string Save()
    {
        return "Save to SQLLite";
    }
}