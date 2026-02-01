using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using Earth.Data;
using Earth.Models;

namespace Earth.Pages_AdminExploreTopics
{
    public class DetailsModel : PageModel
    {
        private readonly Earth.Data.EarthContext _context;

        public DetailsModel(Earth.Data.EarthContext context)
        {
            _context = context;
        }

        public ExploreTopic ExploreTopic { get; set; } = default!;

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var exploretopic = await _context.ExploreTopics.FirstOrDefaultAsync(m => m.Id == id);

            if (exploretopic is not null)
            {
                ExploreTopic = exploretopic;

                return Page();
            }

            return NotFound();
        }
    }
}
