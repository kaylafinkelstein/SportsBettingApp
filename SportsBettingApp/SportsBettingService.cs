using Microsoft.AspNetCore.DataProtection.KeyManagement;
using Microsoft.VisualBasic;
using Newtonsoft.Json;
using RestSharp;
using SportsBettingApp.Models;
using System.Collections;
using System.Reflection.Metadata.Ecma335;
using System.Threading;
using SportsBettingApp.Controllers;

namespace SportsBettingApp
{
    public class SportsBettingService
    {
        private RestClient client = new RestClient("https://api.the-odds-api.com/v4/sports");
        private string FOOTBALL_KEY = "americanfootball_nfl";
        private string AMERICANFOOTBALL_NCAAF_KEY = "americanfootball_ncaaf";
        private string NBA_KEY = "basketball_nba";
        private string HOCKEY_KEY = "icehockey_nhl";
        private string API_KEY = "bd863a170e635cd705d3ea4992848f24";
        

        public async Task<IEnumerable<GameOdds>> GetNFLOdds()
        {
            var request = new RestRequest($"/{FOOTBALL_KEY}/odds?apiKey={API_KEY}&regions=us");
            var response = await client.GetAsync(request);

            var result = JsonConvert.DeserializeObject<IEnumerable<GameOdds>>(response.Content);
            
            return result;
        }
        public async Task<IEnumerable<GameOdds>> GetCollegeFootballOdds()
        {
            var request = new RestRequest($"/{AMERICANFOOTBALL_NCAAF_KEY}/odds?apiKey={API_KEY}&regions=us");
            var response = await client.GetAsync(request);

            var result = JsonConvert.DeserializeObject<IEnumerable<GameOdds>>(response.Content);

            return result;
        }

        public async Task<GameOdds> GetDetailedNCAAFOdds(string gameID)
        {
            var request = new RestRequest($"/{AMERICANFOOTBALL_NCAAF_KEY}/events/{gameID}/odds?apiKey={API_KEY}&regions=us&markets=h2h,spreads,totals");
            var response = await client.GetAsync(request);

            var result = JsonConvert.DeserializeObject<GameOdds>(response.Content);

            return result;
        }

        public async Task<IEnumerable<GameOdds>> GetNBAOdds()
        {
            var request = new RestRequest($"/{NBA_KEY}/odds?apiKey={API_KEY}&regions=us");
            var response = await client.GetAsync(request);

            var result = JsonConvert.DeserializeObject<IEnumerable<GameOdds>>(response.Content);

            return result;
        }
        public async Task<IEnumerable<GameOdds>> GetNHLOdds()
        {
            var request = new RestRequest($"/{HOCKEY_KEY}/odds?apiKey={API_KEY}&regions=us");
            var response = await client.GetAsync(request);

            var result = JsonConvert.DeserializeObject<IEnumerable<GameOdds>>(response.Content);

            return result;
        }

        public async Task<GameOdds> GetDetailedNFLOdds(string gameId)
        {
            var request = new RestRequest($"/{FOOTBALL_KEY}/events/{gameId}/odds?apiKey={API_KEY}&regions=us&markets=h2h,spreads,totals");
            var response = await client.GetAsync(request);

            var result = JsonConvert.DeserializeObject<GameOdds>(response.Content);

            return result;
        }
        public async Task<GameOdds>GetDetailedNBAOdds(string gameID)
        {
            var request = new RestRequest($"/{NBA_KEY}/events/{gameID}/odds?apiKey={API_KEY}&regions=us&markets=h2h,spreads,totals");

            var response = await client.GetAsync(request);

            var result = JsonConvert.DeserializeObject<GameOdds>(response.Content);

            return result;
        }
        public async Task<GameOdds> GetDetailedNHLOdds(string gameID)
        {
            var request = new RestRequest($"/{HOCKEY_KEY}/events/{gameID}/odds?apiKey={API_KEY}&regions=us&markets=h2h,spreads,totals");

            var response = await client.GetAsync(request);

            var result = JsonConvert.DeserializeObject<GameOdds>(response.Content);

            return result;
        }




    }
}
