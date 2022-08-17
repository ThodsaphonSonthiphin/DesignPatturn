using CoP;

public class OfficerRoleHandler : Handler
{
    public override bool HandleRequest(User user)
    {
        if (user.RoleId == 3)
        {
            Console.WriteLine("is Officer");
            return true;
        }
        else if (Successor != null)
        {
            return Successor.HandleRequest(user);
        }
        return false;
    }
}