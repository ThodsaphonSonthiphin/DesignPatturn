namespace Bridge;

public class AppleSmartWatchImplement : IImplementation
{
    public string CountHeartRate()
    {
        return $" Heart Rate is 180";
    }

    public string MeasureDistance()
    {
        return $"100 meter";
    }
}