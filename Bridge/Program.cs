//https://online.visual-paradigm.com/w/pplxtipa/diagrams/#diagram:workspace=pplxtipa&proj=0&id=15
using Bridge;

var appleWatchImplement = new AppleSmartWatchImplement();

var appleWatch = new AppleWatch(appleWatchImplement);

Client client1 = new Client(appleWatch);

client1.Exercise();

IPhone iPhone = new IPhone(appleWatchImplement);

Client client2 = new Client(iPhone);