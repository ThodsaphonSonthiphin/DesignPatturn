namespace Bridge;

public class Client
{
    private readonly Activity _activityApp;

    public Client(Activity activityApp)
    {
        _activityApp = activityApp;
    }

    public void Exercise()
    {
        Console.WriteLine(this._activityApp.CheckHeartRate());

        Console.WriteLine(this._activityApp.OutdoorRunning());
    }
}