using System;
using System.Linq;
using Assignment10.Models;
using Microsoft.AspNetCore.Mvc;

namespace Assignment10.Components
{
    public class TeamNameViewComponent : ViewComponent
    {
        private BowlingLeagueContext context;

        public TeamNameViewComponent(BowlingLeagueContext ctx)
        {
            context = ctx;
        }

        public IViewComponentResult Invoke()
        {
            ViewData["SelectedType"] = RouteData?.Values["teamName"];
       
            return View(context.Teams
                .Distinct()
                .OrderBy(x => x));
        }
    }
}
