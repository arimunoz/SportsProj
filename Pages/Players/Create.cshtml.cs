using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using SportsProj.Models;

namespace SportsProj.Pages.Players
{
    public class CreateModel : PageModel
    {
        private readonly SportsProj.Models.AthleteStatsContext _context;

        public CreateModel(SportsProj.Models.AthleteStatsContext context)
        {
            _context = context;
        }

        public IActionResult OnGet()
        {
            return Page();
        }

        [BindProperty]
        public Player Player { get; set; }

        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            var emptyPlayer = new Player();

            if (await TryUpdateModelAsync<Player>(
                emptyPlayer,
                "Player",   // Prefix for form value.
                p => p.FirstName, p => p.LastName, p => p.Team))
            {

                _context.Player.Add(Player);
                await _context.SaveChangesAsync();

                return RedirectToPage("./Index");
            }
            return null;
        }
            
    }
}