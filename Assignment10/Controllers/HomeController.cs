using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Assignment10.Models;
using Microsoft.EntityFrameworkCore;
using Assignment10.Models.ViewModels;

//home controller
namespace Assignment10.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private BowlingLeagueContext context { get; set; }

        public HomeController(ILogger<HomeController> logger, BowlingLeagueContext ctx)
        {
            _logger = logger;
            context = ctx;
        }

        public IActionResult Index(long? teamNameId, string teamName, int pageNum = 0)
        {
            //how many results are displayed per page
            int pageSize = 5;

            return View(new IndexViewModel
            {
                Bowlers = (context.Bowlers
                .Where(x => x.TeamId == teamNameId || teamNameId == null)
                .OrderBy(x => x.BowlerLastName)
                .Skip((pageNum - 1) * pageSize)
                .Take(pageSize)
                .ToList()),

                PageNumberingInfo = new PageNumberingInfo

                {
                    NumItemsPerPage = pageSize,
                    CurrentPage = pageNum,

                    //if no team has been selected, then get full count. otherwise, only count the number from the
                    //team name that has been selected
                    TotalNumItems = (teamNameId == null ? context.Bowlers.Count() :
                        context.Bowlers.Where(x => x.TeamId == teamNameId).Count())

                },

                TeamCategory = teamName

            }) ;
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
