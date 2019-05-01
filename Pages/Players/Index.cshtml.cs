using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using SportsProj.Models;

namespace SportsProj.Pages.Players
{
    public class IndexModel : PageModel
    {
        private readonly SportsProj.Models.AthleteStatsContext _context;

        public IndexModel(SportsProj.Models.AthleteStatsContext context)
        {
            _context = context;
        }

        public string NameSort { get; set; }
        public string CurrentFilter { get; set; }
        public string CurrentSort { get; set; }


        public IList<Player> Player { get;set; }

        public async Task OnGetAsync(string sortOrder, string searchString)
        {
            NameSort = String.IsNullOrEmpty(sortOrder) ? "name_desc": "";
            CurrentFilter = searchString;
            IQueryable<Player> playerSort = from p in _context.Player select p;
            if (!String.IsNullOrEmpty(searchString))
            {
                playerSort = playerSort.Where(p => p.LastName.Contains(searchString) || p.FirstName.Contains(searchString));
            }

            switch (sortOrder)
            {
                case "name_desc":
                    playerSort = playerSort.OrderByDescending(p => p.LastName);
                    break;
                default:
                    playerSort = playerSort.OrderBy(s => s.LastName);
                    break;
            }

            Player = await playerSort.AsNoTracking().ToListAsync();
        }
    }
}
