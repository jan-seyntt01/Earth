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
    public class DeleteModel : PageModel
    {
        private readonly Earth.Data.EarthContext _context;

        public DeleteModel(Earth.Data.EarthContext context)
        {
            _context = context;
        }

        [BindProperty]
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

        public async Task<IActionResult> OnPostAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var exploretopic = await _context.ExploreTopics.FindAsync(id);
            if (exploretopic != null)
            {
                ExploreTopic = exploretopic;
                _context.ExploreTopics.Remove(ExploreTopic);
                await _context.SaveChangesAsync();
            }

            return RedirectToPage("./Index");
        }
    }
}
