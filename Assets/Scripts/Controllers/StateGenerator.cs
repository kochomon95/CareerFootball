public static class StatGenerator
{
    public static PlayerAttributes Generate(string position)
    {
        PlayerAttributes stats = new PlayerAttributes();

        switch (position)
        {
            case "CB":
                stats.Add("Tackling", 80);
                stats.Add("Pace", 65);
                stats.Add("Passing", 60);
                stats.Add("Strength", 80);
                stats.Add("Stamina", 70);
                break;

            case "CM":
                stats.Add("Dribbling", 65);
                stats.Add("Pace", 65);
                stats.Add("Passing", 80);
                stats.Add("Strength", 70);
                stats.Add("Stamina", 70);
                break;

            case "CF":
                stats.Add("Finishing", 80);
                stats.Add("Pace", 78);
                stats.Add("Passing", 78);
                stats.Add("Strength", 70);
                stats.Add("Stamina", 70);
                break;

            default:
                stats.Add("Pace", 50);
                stats.Add("Passing", 50);
                stats.Add("Strength", 50);
                stats.Add("Stamina", 50);
                stats.Add("Dribbling", 50);
                break;
        }

        return stats;
    }
}