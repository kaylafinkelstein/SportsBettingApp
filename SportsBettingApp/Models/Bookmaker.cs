namespace SportsBettingApp.Models
{
    public class Bookmaker
    {
        public string key { get; set; }
        public string title { get; set; }

        public IEnumerable<Market> markets { get; set; }
    }
}


/*
 * 
 * {
                "key": "unibet",
                "title": "Unibet",
                "last_update": "2021-06-10T13:33:18Z",
                "markets": [
                    {
                        "key": "h2h",
                        "outcomes": [
                            {
                                "name": "Dallas Cowboys",
                                "price": 240
                            },
                            {
                                "name": "Tampa Bay Buccaneers",
                                "price": -303
                            }
                        ]
                    },
                    {
                        "key": "spreads",
                        "outcomes": [
                            {
                                "name": "Dallas Cowboys",
                                "price": -109,
                                "point": 6.5
                            },
                            {
                                "name": "Tampa Bay Buccaneers",
                                "price": -111,
                                "point": -6.5
                            }
                        ]
                    }
                ]
            }
 * */