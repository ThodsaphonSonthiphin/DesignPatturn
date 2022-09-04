
using Proxy;

var report = new Report();

var proxy = new ReportProxy(report);

var client = new Client();

Console.WriteLine(client.ViewReport(proxy));