using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using SportsProj.Data;

namespace SportsProj.Pages
{
    [Authorize]
    public class BattingModel : PageModel
    {
        CrudOps _battingRepository;
        public BattingModel(CrudOps Repo)
        {
            _battingRepository = Repo;
        }

        [BindProperty]
        public List<Models.Batting> batting { get; set; }

        [BindProperty]
        public Models.Batting Batting { get; set; }

        [TempData]
        public string Message { get; set; }

        public void OnGet()
        {
            batting = _battingRepository.GetListBatting();
        }
    }
}
