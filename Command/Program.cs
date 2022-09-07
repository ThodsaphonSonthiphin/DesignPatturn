
using Command;


AssignAdminCommand adminCommand = new AssignAdminCommand("Admin",new Receiver());

Assign assignment = new Assign(adminCommand);

assignment.Execute();