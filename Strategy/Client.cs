namespace Strategy;

public class Client
{
    public readonly AssignContext Context;
   

    public Client(AssignContext context)
    {
        Context = context;
       
    }

    public void Save()
    {
        Console.WriteLine(this.Context.SaveChange());
    }
}