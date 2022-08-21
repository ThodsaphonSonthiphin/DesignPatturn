namespace Bridge;

public abstract class Activity
{
    protected readonly IImplementation _implementation;

    public Activity(IImplementation implementation)
    {
        _implementation = implementation;
    }
    public abstract string CheckHeartRate();
    public abstract string OutdoorRunning();
}