public class User:ISubscriber
{
    private sealed class NameEqualityComparer : IEqualityComparer<User>
    {
        public bool Equals(User x, User y)
        {
            if (ReferenceEquals(x, y)) return true;
            if (ReferenceEquals(x, null)) return false;
            if (ReferenceEquals(y, null)) return false;
            if (x.GetType() != y.GetType()) return false;
            return x.Name == y.Name;
        }

        public int GetHashCode(User obj)
        {
            return obj.Name.GetHashCode();
        }
    }


    public string Name { get; set; }
    public void Update(Issue issueUpdate)
    {
        Console.WriteLine($"Notify {Name}");
    }
}