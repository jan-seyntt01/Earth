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
    public class IndexModel : PageModel
    {
        private readonly Earth.Data.EarthContext _context;

        public IndexModel(Earth.Data.EarthContext context)
        {
            _context = context;
        }

        public IList<AboutContent> AboutContent { get;set; } = default!;

        public async Task OnGetAsync()
        {
            AboutContent = await _context.AboutContents.ToListAsync();
        }
    }
}
