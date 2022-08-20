namespace Adapter;

public class WriteToFileAdapter:IClientLogging
{
    private readonly FileWriter _fileWriter;
    private readonly string _path;

    public WriteToFileAdapter(FileWriter fileWriter,string path)
    {
        _fileWriter = fileWriter;
        _path = path;
    }
    public bool WriteLog(string logInfo)
    {
        return  _fileWriter.WriteToFile(logInfo, this._path);
    }
}