
using Flyweight;

var factory = new ProvinceFactory(new ProvinceFlyweights("bbk","10"));


List<Officer> officers = new List<Officer>();
officers.Add(new Officer(factory, "bbk officer", "bbk", "10"));

officers.Add(new Officer(factory, "bbk officer 2", "bbk", "10"));

officers.Add(new Officer(factory, "krabi officer ", "krabi", "11"));

foreach (Officer officer in officers)
{
    Console.WriteLine(officer);
}


Console.WriteLine("\n \n all flyweight");

factory.listFlyweights();