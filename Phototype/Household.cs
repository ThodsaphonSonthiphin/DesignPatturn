namespace Phototype;

public class Household
{
    public Household(string houseNumber)
    {
        HouseNumber = houseNumber;
    }

    public Household DeepCopy()
    {
        return (Household) this.MemberwiseClone();
    }

    public string HouseNumber { get; set; } 
}