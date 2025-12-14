using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using Earth.Data;
using Earth.Models;

namespace Earth.Pages.EarthModel
{
    public class EditModel : PageModel
    {
        private readonly Earth.Data.EarthContext _context;

        public EditModel(Earth.Data.EarthContext context)
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

            var earthmodel =  await _context.EarthModel.FirstOrDefaultAsync(m => m.ID == id);
            if (earthmodel == null)
            {
                return NotFound();
            }
            EarthModel = earthmodel;
            return Page();
        }

        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more information, see https://aka.ms/RazorPagesCRUD.
        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            _context.Attach(EarthModel).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!EarthModelExists(EarthModel.ID))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }

            return RedirectToPage("./Index");
        }

        private bool EarthModelExists(int id)
        {
            return _context.EarthModel.Any(e => e.ID == id);
        }
    }
}
