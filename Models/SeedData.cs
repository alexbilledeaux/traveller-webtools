using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using Traveller.Data;
using System;
using System.Linq;

namespace Traveller.Models
{
    public static class SeedData
    {
        public static void Initialize(IServiceProvider serviceProvider)
        {
            using (var context = new TravellerContext(
                serviceProvider.GetRequiredService<
                    DbContextOptions<TravellerContext>>()))
            {
                // Look for any planets.
                if (context.Planet.Any())
                {
                    return;   // DB has been seeded
                }

                context.Planet.AddRange(
                    new Planet {},

                    new Planet {},

                    new Planet {},

                    new Planet {}
                );
                context.SaveChanges();
            }
        }
    }
}