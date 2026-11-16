using System.Collections.Generic;

[System.Serializable]
public class StatEntry
{
    public string name;
    public int value;

    public StatEntry(string name, int value)
    {
        this.name = name;
        this.value = value;
    }
}
[System.Serializable]
public class PlayerAttributes
{
    public List<StatEntry> list = new List<StatEntry>();

    public void Add(string name, int value)
    {
        list.Add(new StatEntry(name, value));
    }
}