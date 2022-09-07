namespace Command;

public class AssignAdminCommand : IMyCommand
{
    private readonly Receiver _receiver;

    public AssignAdminCommand(string role,Receiver receiver)
    {
        _receiver = receiver;
        Role = role;
    }

    public string Role { get; set; }
    public string AssignOperation()
    {
       return this._receiver.AssignOperation(this.Role);
    }
}