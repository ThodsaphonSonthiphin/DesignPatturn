namespace Bridge;

public class IPhone : Activity
{
    public IPhone(IImplementation implementation) : base(implementation)
    {
    }

    public override string CheckHeartRate()
    {
        return $"Activity App ======= \n {this._implementation.CountHeartRate()}";
    }

    public override string OutdoorRunning()
    {
        return
            $"Activity App ======== \n {this._implementation.CountHeartRate()} and distant  {this._implementation.MeasureDistance()}";
    }

    public string Call()
    {
        return "Call someone";
    }
}