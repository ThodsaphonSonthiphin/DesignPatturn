using Facade;

public class Client
{
    public string DeleteAccount(DeleteAccountFacade facade)
    {
        return facade.DeleteAccount();
    }
}