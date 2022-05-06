using Microsoft.EntityFrameworkCore;
using RazorPagesMS.Data;


namespace RazorPagesMS.Models
{
    public static class SeedData
    {
        public static void Initialize(IServiceProvider serviceProvider)
        {
            using (var context = new RazorPagesMSContext(
                serviceProvider.GetRequiredService<DbContextOptions<RazorPagesMSContext>>()))
            {
                if(context == null || context.Movie == null)
                {
#pragma warning disable CA2208 // Instantiate argument exceptions correctly
                    throw new ArgumentNullException("Null RazorPagesMSContext");
#pragma warning restore CA2208 // Instantiate argument exceptions correctly
                }

                //Look for any movies 
                if (context.Movie.Any())
                {
                    return; //Means Database has been seeded properly
                }

                context.Movie.AddRange(
                    new Movie
                    {
                        Title = "Lord of the Rings - The fellowship of the ring",
                        ReleaseDate = DateTime.Parse("01/01/2000"),
                        Genre = "Sci-fi",
                        Price = (decimal) 29.95,
                        Rating = 98,
                        Review = "alksjdkalsj dl;kasj d;lkasjd l;kas;j dlk asjdsa dhasjdha skj dhklas"
                       
                    },
                    new Movie
                    {
                        Title = "Lord of the Rings - The Two Towers",
                        ReleaseDate = DateTime.Parse("01/01/2002"),
                        Genre = "Sci-fi",
                        Price = (decimal) 29.55,
                        Rating = 98,
                        Review = "alksjdkalsj dl;kasj d;lkasjd l;kas;j dlk asjdsa dhasjdha skj dhklas"

                    },
                    new Movie
                    {
                        Title = "Lord of the Rings - The Return of the King",
                        ReleaseDate = DateTime.Parse("01/01/2004"),
                        Genre = "Sci-fi",
                        Price = (decimal) 39.95,
                        Rating = 98,
                        Review = "alksjdkalsj dl;kasj d;lkasjd l;kas;j dlk asjdsa dhasjdha skj dhklas"

                    }
                );
                context.SaveChanges();

            }
        }
    }
}
