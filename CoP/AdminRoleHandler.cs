using CoP;

public class AdminRoleHandler : Handler
{
    public override bool HandleRequest(User user)
    {
        if (user.RoleId == 2)
        {
            Console.WriteLine("is admin");
            return true;
        }
        else if (Successor != null)
        {
            return Successor.HandleRequest(user);
        }
        return false;
    }
}