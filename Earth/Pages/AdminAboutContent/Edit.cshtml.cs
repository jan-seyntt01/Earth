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

namespace Earth.Pages_AdminAboutContent
{
    public class EditModel : PageModel
    {
        private readonly Earth.Data.EarthContext _context;

        public EditModel(Earth.Data.EarthContext context)
        {
            _context = context;
        }

        [BindProperty]
        public AboutContent AboutContent { get; set; } = default!;

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var aboutcontent =  await _context.AboutContents.FirstOrDefaultAsync(m => m.Id == id);
            if (aboutcontent == null)
            {
                return NotFound();
            }
            AboutContent = aboutcontent;
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

            _context.Attach(AboutContent).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!AboutContentExists(AboutContent.Id))
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

        private bool AboutContentExists(int id)
        {
            return _context.AboutContents.Any(e => e.Id == id);
        }
    }
}
