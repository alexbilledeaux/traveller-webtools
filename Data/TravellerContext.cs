using Microsoft.EntityFrameworkCore;
using Traveller.Models;

namespace Traveller.Data
{
    public class TravellerContext : DbContext
    {
        public TravellerContext (DbContextOptions<TravellerContext> options)
            : base(options)
        {
        }

        public DbSet<Planet> Planet { get; set; }
    }
}