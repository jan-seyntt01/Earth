using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Earth.Models;

namespace Earth.Data
{
    public class EarthContext : DbContext
    {
        public EarthContext (DbContextOptions<EarthContext> options)
            : base(options)
        {
        }

        public DbSet<Earth.Models.EarthModel> EarthModel { get; set; } = default!;
    }
}
