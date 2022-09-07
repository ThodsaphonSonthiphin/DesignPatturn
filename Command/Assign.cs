namespace Command;

public class Assign
{
    private readonly IMyCommand _command;

    public Assign(IMyCommand command)
    {
        _command = command;
    }

    public void Execute()
    {
        Console.WriteLine(this._command.AssignOperation());
    }
}