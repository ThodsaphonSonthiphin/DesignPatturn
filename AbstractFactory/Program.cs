
using AbstractFactory;

var gamingFactory = new GamingFactory();


var gamer = new Client(gamingFactory);

gamer.Work();


Console.WriteLine("=========");

var workStation = new WorkStationFactory();

var officeStaff = new Client(workStation);

officeStaff.Work();

