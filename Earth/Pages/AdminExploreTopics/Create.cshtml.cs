using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using Earth.Data;
using Earth.Models;

namespace Earth.Pages_AdminExploreTopics
{
    public class CreateModel : PageModel
    {
        private readonly Earth.Data.EarthContext _context;

        public CreateModel(Earth.Data.EarthContext context)
        {
            _context = context;
        }

        public IActionResult OnGet()
        {
            return Page();
        }

        [BindProperty]
        public ExploreTopic ExploreTopic { get; set; } = default!;

        // For more information, see https://aka.ms/RazorPagesCRUD.
        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            _context.ExploreTopics.Add(ExploreTopic);
            await _context.SaveChangesAsync();

            return RedirectToPage("./Index");
        }
    }
}
