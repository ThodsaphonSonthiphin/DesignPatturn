// See https://aka.ms/new-console-template for more information

using Iterator;

var collection = new IssueEnumerable();

for (int i = 1; i <= 10; i++)
{
    collection.AddItem(new Issue(i.ToString(),false));
}


foreach (var issue in collection)
{
    Console.WriteLine(issue);
}