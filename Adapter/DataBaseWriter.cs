namespace Adapter;

public class DataBaseWriter
{
    public bool WriteToDb(string logInfo, string connectionString)
    {
        Console.WriteLine($" {logInfo} to Db with {connectionString}");
        return true;
    }
}