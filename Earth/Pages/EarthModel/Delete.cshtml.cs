using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using Earth.Data;
using Earth.Models;

namespace Earth.Pages.EarthModel
{
    public class DeleteModel : PageModel
    {
        private readonly Earth.Data.EarthContext _context;

        public DeleteModel(Earth.Data.EarthContext context)
        {
            _context = context;
        }

        [BindProperty]
        public Earth.Models.EarthModel EarthModel { get; set; } = default!;

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var earthmodel = await _context.EarthModel.FirstOrDefaultAsync(m => m.ID == id);

            if (earthmodel is not null)
            {
                EarthModel = earthmodel;

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

            var earthmodel = await _context.EarthModel.FindAsync(id);
            if (earthmodel != null)
            {
                EarthModel = earthmodel;
                _context.EarthModel.Remove(EarthModel);
                await _context.SaveChangesAsync();
            }

            return RedirectToPage("./Index");
        }
    }
}
