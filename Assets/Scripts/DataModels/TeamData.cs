using System;
using System.Collections.Generic;

[Serializable]
public class TeamData
{
    public int teamId;
    public string teamName;
    public string teamShortName;
}

[Serializable]
public class TeamDatabase
{
    public List<TeamData> teams;
}