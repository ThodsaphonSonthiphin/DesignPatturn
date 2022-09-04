namespace Proxy;

public class ReportProxy : IReport
{
    private readonly Report _report;

    public ReportProxy(Report report)
    {
        _report = report;
    }
    public string ShowReport()
    {
        Console.WriteLine("Proxy Logging");
        return this._report.ShowReport();
    }
}