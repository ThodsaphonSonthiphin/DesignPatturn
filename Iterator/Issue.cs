namespace Iterator;

public class Issue
{
    public Issue(string name, bool approve)
    {
        Name = name;
        Approve = approve;
    }

    public string Name { get; set; }
    public bool Approve { get; set; }

    public override string ToString()
    {
        return $"{Name} {Approve}";
    }
}