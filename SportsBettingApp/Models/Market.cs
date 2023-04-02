namespace SportsBettingApp.Models
{
    public class Market
    {
        public string key { get; set; }
        public IEnumerable<Outcome> outcomes { get; set; }
    }
}