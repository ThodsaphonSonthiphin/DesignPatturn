namespace AbstractFactory;

public class WorkStationHeadSet : IHeadSet
{


    public void Play()
    {
        Console.WriteLine($"sound of {nameof(WorkStationHeadSet)}");
    }
}