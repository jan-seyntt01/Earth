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
    public class DetailsModel : PageModel
    {
        private readonly Earth.Data.EarthContext _context;

        public DetailsModel(Earth.Data.EarthContext context)
        {
            _context = context;
        }

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
    }
}
