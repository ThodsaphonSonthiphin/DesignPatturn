namespace Adapter;

public class DataBaseWriterAdapter:IClientLogging
{
    private readonly DataBaseWriter _dbWriter;
    private readonly string _connectionString;

    public DataBaseWriterAdapter(DataBaseWriter dbWriter,string connectionString)
    {
        _dbWriter = dbWriter;
        _connectionString = connectionString;
    }
    public bool WriteLog(string logInfo)
    {
        return this._dbWriter.WriteToDb(logInfo, _connectionString);
    }
}