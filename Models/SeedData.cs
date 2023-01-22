using Microsoft.EntityFrameworkCore;
using MvcMovie.Data;

namespace MvcMovie.Models
{
    public static class SeedData
    {
        public static void Initialize(IServiceProvider serviceProvider)
        {
            using(var context = new MvcMovieContext(serviceProvider.GetRequiredService<DbContextOptions<MvcMovieContext>>()))
            {
                // Look for existing movies
                if(context.Movie.Any())
                {
                    return; // Db already has data / has been seeded
                }

                context.Movie.AddRange(
                    new Movie
                    {
                        Title = "Star Wars",
                        ReleaseDate= DateTime.Parse("7/21/1978"),
                        Genre = "Science Fiction",
                        Price = 11.0M,
                        Rating = "PG"
                    },
                    
                    new Movie
                    {
                        Title = "Legends of the Fall",
                        ReleaseDate = DateTime.Parse("1/13/1995"),
                        Genre = "Drama",
                        Price = 30.0M,
                        Rating = "R"
                    },
                    new Movie
                    {
                        Title = "When Harry Met Sally",
                        ReleaseDate = DateTime.Parse("1989-2-12"),
                        Genre = "Romantic Comedy",
                        Price = 7.99M,
                        Rating = "PG"
                    },
                    new Movie
                    {
                        Title = "Ghostbusters ",
                        ReleaseDate = DateTime.Parse("1984-3-13"),
                        Genre = "Comedy",
                        Price = 8.99M,
                        Rating = "PG"   
                    },
                    new Movie
                    {
                        Title = "Ghostbusters 2",
                        ReleaseDate = DateTime.Parse("1986-2-23"),
                        Genre = "Comedy",
                        Price = 9.99M,
                        Rating = "PG"   
                    },
                    new Movie
                    {
                        Title = "Rio Bravo",
                        ReleaseDate = DateTime.Parse("1959-4-15"),
                        Genre = "Western",
                        Price = 3.99M,
                        Rating= "NR" 
                    }
                );

                context.SaveChanges();
            }

        }
    }
}
