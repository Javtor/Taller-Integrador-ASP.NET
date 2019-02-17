using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Linq;

namespace QuotationApp.Models
{
    public static class SeedData
    {
        public static void Initialize(IServiceProvider serviceProvider)
        {
            using (var context = new QuotationAppContext(
                serviceProvider.GetRequiredService<
                    DbContextOptions<QuotationAppContext>>()))
            {
                // Look for any movies.
                if (context.EventQuotation.Any())
                {
                    return;   // DB has been seeded
                }

                context.EventQuotation.AddRange(
                    new EventQuotation
                    {
                        Type = "Wedding",
                        Tematic = null,
                        NumberOfPeople = 180,
                        Date = DateTime.Parse("2019-8-26"),
                        hour = DateTime.Parse("2019-9-26"),
                        Colors = "White and pink",
                        FullPackage = true,
                        Details = "The wedding must be classic"
                    }

                );
                
                    context.SaveChanges();
            }
        }
    }
}
