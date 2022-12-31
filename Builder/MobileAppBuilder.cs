namespace Builder;

class MobileAppBuilder : IBuilder
{
    private MobileApplication _mobileApplication;

    public MobileAppBuilder()
    {
        Reset();
    }

    private void Reset()
    {
        this._mobileApplication = new MobileApplication();
    }

    public void AddSecurity()
    {
        this._mobileApplication.Add("Security system");
    }

    public void AddServeStaticFile()
    {
        this._mobileApplication.Add("Serve Static files");
    }

    public void AddLocalDatabase()
    {
        this._mobileApplication.Add("has local database");
    }
    public MobileApplication GetProduct()
    {
        MobileApplication result = this._mobileApplication;

        this.Reset();
    
        return result;
    }

}

internal class MobileApplication
{
    private List<string> FunctionList { get; set; } = new List<string>();

    public void Add(string f)
    {
        this.FunctionList.Add(f);
    }

    public void Show()
    {
        foreach (string s in this.FunctionList)
        {
            Console.WriteLine(s);
        }
    }
}