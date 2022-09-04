namespace Flyweight;

public class ProvinceFactory
{
    private List<ProvinceFlyweights> _provinceFlyweights = new();

    public ProvinceFactory(params ProvinceFlyweights[] args)
    {
        _provinceFlyweights.AddRange(args);
    }

    public ProvinceFlyweights GetProvinceFlyweight(string provinceName, string provinceCode)
    {
        var newProvince = new ProvinceFlyweights(provinceName, provinceCode);

        if (!_provinceFlyweights.Any(x => Equals(x, newProvince)))
        {
            Console.WriteLine($"FlyweightFactory: Can't find a {newProvince.Name} flyweight, creating new one.");
            this._provinceFlyweights.Add(newProvince);
            return newProvince;
        }
        else
        {
            Console.WriteLine($"FlyweightFactory: Reusing existing {newProvince.Name} flyweight.");
        }

        var oldValue = this._provinceFlyweights.First(t => Equals(t, newProvince));

        return oldValue;
    }


    public void listFlyweights()
    {
        var count = this._provinceFlyweights.Count;
        Console.WriteLine($"\nFlyweightFactory: I have {count} flyweights:");
        foreach (var flyweight in this._provinceFlyweights)
        {
            Console.WriteLine(flyweight);
        }
    }
}