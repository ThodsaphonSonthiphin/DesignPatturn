namespace Flyweight;

public class ProvinceFlyweights
{
    protected bool Equals(ProvinceFlyweights other)
    {
        return Name == other.Name && Code == other.Code;
    }

    public override bool Equals(object? obj)
    {
        if (ReferenceEquals(null, obj)) return false;
        if (ReferenceEquals(this, obj)) return true;
        if (obj.GetType() != this.GetType()) return false;
        return Equals((ProvinceFlyweights)obj);
    }

    public override int GetHashCode()
    {
        return HashCode.Combine(Name, Code);
    }


    public ProvinceFlyweights(string name, string code)
    {
        Name = name;
        Code = code;
    }

    public string Name { get; }
    public string Code { get; }

    public override string ToString()
    {
        return $"province name:{Name},province Code:{Code}";
    }
}