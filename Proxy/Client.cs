namespace Proxy;

public class Client
{
    public string ViewReport(IReport report)
    {
        return report.ShowReport();
    }
}