namespace ExtensionMethods.Extensions
{
    public static class SeasonExtensions
    {
        public static Season Next(this Season season)
        {
            int seasonAsInt = (int)season; //casting Season type as an Int
            int nextSeason = (seasonAsInt + 1) % 4;
            return (Season)nextSeason; //return the season and cast it back as a Sesason type
        }
    }

    public enum Season
    {
        Spring,
        Summer,
        Autumn,
        Winter
    }
}
