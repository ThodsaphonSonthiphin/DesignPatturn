using System.Collections;

namespace Iterator;

public class IssueEnumerator : IEnumerator
{
    private readonly IssueEnumerable _issueEnumerable;

    private int _position = -1;

    public IssueEnumerator(IssueEnumerable issueEnumerable)
    {
        this._issueEnumerable = issueEnumerable;
    }

    public bool MoveNext()
    {
        var update = this._position + 1;

        if (update <= this._issueEnumerable.Issues.Count-1)
        {
            this._position = update;
            return true;
        }
        else
        {
            return false;
        }
    }

    public void Reset()
    {
        this._position = -1;
    }

    public object Current => this._issueEnumerable.Issues[_position];
}