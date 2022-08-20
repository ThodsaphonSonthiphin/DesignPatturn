namespace Adapter;

public class Client
{
    private readonly IClientLogging _clientLogging;

    public Client(IClientLogging clientLogging)
    {
        _clientLogging = clientLogging;
    }
    public void Logging()
    {
        _clientLogging.WriteLog("Client is operating");
    }
}