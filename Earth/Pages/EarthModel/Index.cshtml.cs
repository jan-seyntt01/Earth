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
    public class IndexModel : PageModel
    {
        private readonly Earth.Data.EarthContext _context;

        public IndexModel(Earth.Data.EarthContext context)
        {
            _context = context;
        }

        public IList<Earth.Models.EarthModel> EarthModel { get;set; } = default!;

        public async Task OnGetAsync()
        {
            EarthModel = await _context.EarthModel.ToListAsync();
        }
    }
}
