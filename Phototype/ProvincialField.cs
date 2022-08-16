using Phototype;

namespace Prototype;

public class ProvincialField:Admin
{
    //ผู้กำกับงานฯจังหวัด
    public ProvincialField(string province)
    {
        RoleId = 5;
        this.Province = province;
    }

    public string Province { get; set; }
    public Household Household { get; set; } = new Household("10/1");

    public ProvincialField(ProvincialField provincial):base(provincial)
    {
        RoleId = 5;
        Province = provincial.Province;
        Household = provincial.Household.DeepCopy();
    }
   

    public override Admin ShallowCopy()
    {
        return (Admin) this.MemberwiseClone();
    }

    public override Admin DeepCopy()
    {
        var a = new ProvincialField(this);

        
        return (Admin)a;
    }

    public override string ToString()
    {
        var myString = base.ToString();
        return myString + $"{nameof(Province)}:{Province} \n";
    }
}