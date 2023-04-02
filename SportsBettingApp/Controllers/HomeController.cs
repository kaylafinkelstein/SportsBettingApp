using Microsoft.AspNetCore.Mvc;
using SportsBettingApp.Models;
using System.Diagnostics;


namespace SportsBettingApp.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly SportsBettingService oddsService = new SportsBettingService();

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public async Task<IActionResult> Index()
        {
            var nflOdds = await oddsService.GetNFLOdds();
            var nbaOdds = await oddsService.GetNBAOdds();
            var ncaaOdds = await oddsService.GetCollegeFootballOdds();
            var nhlOdds = await oddsService.GetNHLOdds();
            

            return View(
                new AggregateOdds
                {
                    NcaaOdds = ncaaOdds,
                    BasketballOdds = nbaOdds,
                    FootballOdds = nflOdds,
                    HockeyOdds = nhlOdds
                }
            );
        }
        public async Task<IActionResult> NFLDetails(string id)
        {

            var detailedOdds = await oddsService.GetDetailedNFLOdds(id);

            return View(detailedOdds);
        }
        public async Task<IActionResult> NCAAFIndex()
        {
            var odds = await oddsService.GetCollegeFootballOdds();

            return View(odds);
        }
        public async Task<IActionResult> NCAAFDetails(string id)
        {
            var detailedOdds = await oddsService.GetDetailedNCAAFOdds(id);

            return View(detailedOdds);
        }
        public async Task<IActionResult> IndexC()
        {
            var odds = await oddsService.GetNBAOdds();
            return View(odds); 
        }
        public async Task<IActionResult> NBADetails(string id)
        {
            var detailedOdds = await oddsService.GetDetailedNBAOdds(id);

            return View(detailedOdds);
        }

        public async Task<IActionResult> IndexA()
        {
            var odds = await oddsService.GetNHLOdds();
            return View(odds);
        }
        public async Task<IActionResult> NHLDetails(string id)
        {
            var detailedOdds = await oddsService.GetDetailedNHLOdds(id);

            return View(detailedOdds);
        }


        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}