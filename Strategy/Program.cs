
using Strategy;

SQLLiteSave sqlLite = new SQLLiteSave();
AssignContext assignContext = new AssignContext(sqlLite);
Client client = new Client(assignContext);

client.Save();

DbSave dbSave = new DbSave();

client.Context.Strategy = dbSave;

client.Save();