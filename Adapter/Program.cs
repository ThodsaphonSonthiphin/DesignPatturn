//https://online.visual-paradigm.com/w/pplxtipa/diagrams/#diagram:workspace=pplxtipa&proj=0&id=13

using Adapter;

var dbWriter = new DataBaseWriter();

var dbAdapter = new DataBaseWriterAdapter(dbWriter, "Azure server");

var client1 = new Client(dbAdapter);

client1.Logging();

var file = new FileWriter();
var fileAdapter = new WriteToFileAdapter(file, "c:\\");

var client2 = new Client(fileAdapter);

client2.Logging();