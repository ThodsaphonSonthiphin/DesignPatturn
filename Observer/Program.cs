User teamLeader =new User(){Name = "Team leader"};

User OfficerA = new User() { Name = "Officer A" };

User OfficerB = new User() { Name = "Officer A" };


var issue = new Issue(teamLeader, OfficerA, OfficerB);

issue.Approve(OfficerA);

issue.Approve(teamLeader);
