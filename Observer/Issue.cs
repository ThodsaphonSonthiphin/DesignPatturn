public class Issue
{
    public Issue(ISubscriber teamLeader,params ISubscriber[] ownerList)
    {
        OwnerList = ownerList.ToList();
        TeamLeader = teamLeader;
    }

    public void Approve(User user)
    {
        if (user.Equals(this.TeamLeader))
        {
            Console.WriteLine("Approve success");

            foreach (var subscriber in this.OwnerList)
            {
                subscriber.Update(this);
            }

            TeamLeader.Update(this);

        }
        else
        {
            Console.WriteLine("Don't have permission");
        }
    }


    public List<ISubscriber> OwnerList { get; set; }
    public ISubscriber? TeamLeader { get; set; }

    public bool RemoveOwner(ISubscriber subscriber)
    {
        return this.OwnerList.Remove(subscriber);
    }

    public void AddOwner(ISubscriber subscriber)
    {
        OwnerList.Add(subscriber);
    }

    public void RemoveTeamLeader()
    {
        TeamLeader = null;
    }

    public void AssignTeamLeader(ISubscriber subscriber)
    {
        TeamLeader = subscriber;
    }


}