using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using Earth.Data;
using Earth.Models;

namespace Earth.Pages_AdminAboutContent
{
    public class DetailsModel : PageModel
    {
        private readonly Earth.Data.EarthContext _context;

        public DetailsModel(Earth.Data.EarthContext context)
        {
            _context = context;
        }

        public AboutContent AboutContent { get; set; } = default!;

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var aboutcontent = await _context.AboutContents.FirstOrDefaultAsync(m => m.Id == id);

            if (aboutcontent is not null)
            {
                AboutContent = aboutcontent;

                return Page();
            }

            return NotFound();
        }
    }
}
