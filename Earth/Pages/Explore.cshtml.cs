using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using Earth.Data;
using Earth.Models;

namespace Earth.Pages
{
    public class ExploreModel : PageModel
    {
        private readonly EarthContext _context;
        public List<ExploreTopic> ExploreTopics { get; set; } = new();

        public ExploreModel(EarthContext context)
        {
            _context = context;
        }

        public async Task OnGetAsync()
        {
            ExploreTopics = await _context.ExploreTopics.ToListAsync();
        }
    }
}