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
    public class DetailsModel : PageModel
    {
        private readonly SportsProj.Models.AthleteStatsContext _context;

        public DetailsModel(SportsProj.Models.AthleteStatsContext context)
        {
            _context = context;
        }

        public Player Player { get; set; }

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            Player = await _context.Player.Include(p => p.Teams).ThenInclude(t => t.Stat).AsNoTracking().FirstOrDefaultAsync(m => m.PlayerID == id);

            if (Player == null)
            {
                return NotFound();
            }
            return Page();
        }
    }
}
