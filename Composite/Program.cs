using Composite;

var teamA = new TeamLeader();
var teamB = new TeamLeader();
var teamC = new TeamLeader();

teamB.Add(teamC);

for (int i = 0; i < 10; i++)
{
    teamA.Add(new Officer());
    teamB.Add(new Officer());
    teamC.Add(new Officer());
}

Console.WriteLine(teamA.ToString());
Console.WriteLine(teamB.ToString());
