
//https://online.visual-paradigm.com/w/pplxtipa/diagrams/#diagram:workspace=pplxtipa&proj=0&id=10
using AbstractFactory;

var gamingFactory = new GamingFactory();


var gamer = new Client(gamingFactory);

gamer.Work();


Console.WriteLine("=========");

var workStation = new WorkStationFactory();

var officeStaff = new Client(workStation);

officeStaff.Work();

