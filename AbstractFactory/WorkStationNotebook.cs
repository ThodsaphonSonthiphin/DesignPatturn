namespace AbstractFactory;

public class WorkStationNotebook : INoteBook
{
    public void TurnOn()
    {
        Console.WriteLine($"{nameof(WorkStationNotebook)} turn on");
    }

    public void TurnOff()
    {
        Console.WriteLine($"{nameof(WorkStationNotebook)} turn off");
    }
}