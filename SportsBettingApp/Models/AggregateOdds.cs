namespace SportsBettingApp.Models
{
    public class AggregateOdds
    {
        public IEnumerable<GameOdds> FootballOdds { get; set; }
        public IEnumerable<GameOdds> BasketballOdds { get; set; }
        public IEnumerable<GameOdds> HockeyOdds { get; set; }
        public IEnumerable<GameOdds> NcaaOdds { get; set; }
    }
}
