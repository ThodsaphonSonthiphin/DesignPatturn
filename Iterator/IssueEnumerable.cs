using System.Collections;

namespace Iterator;

public class IssueEnumerable : IEnumerable
{
    public List<Issue> Issues { get; set; } = new List<Issue>();

    public void AddItem(Issue issue)
    {
        this.Issues.Add(issue);
    }

    public bool RemoveItem(Issue issue)
    {
        return this.Issues.Remove(issue);
    }

    public IEnumerator GetEnumerator()
    {
        return new IssueEnumerator(this);
    }
}