
var admin = new User(2);
var officer = new User(3);

var chain1 = new AdminRoleHandler();
var chain2 = new OfficerRoleHandler();

chain1.SetSuccessor(chain2);


var adminResult = chain1.HandleRequest(admin);

var officerResult = chain1.HandleRequest(officer);

Console.WriteLine($"admin: {adminResult}");

Console.WriteLine($"Officer: {officerResult}");