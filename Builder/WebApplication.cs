namespace Builder;

public class WebApplication
{
    private List<string> FunctionList { get; set; } = new List<string>();

    public void Add(string f)
    {
        this.FunctionList.Add(f);
    }

    public void Show()
    {
        foreach (string s in this.FunctionList)
        {
            Console.WriteLine(s);
        }
    }

}