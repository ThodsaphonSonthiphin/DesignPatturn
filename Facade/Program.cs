// See https://aka.ms/new-console-template for more information

using Facade;


var deleteFacade = new DeleteAccountFacade(new AdminSystem(),new AssignmentSystem(),new ListingSystem());

Client client = new Client();


Console.WriteLine(client.DeleteAccount(deleteFacade));