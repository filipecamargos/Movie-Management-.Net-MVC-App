using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using MvcMovie.Data;
using System;
using System.Linq;

namespace MvcMovie.Models
{
    public static class SeedData
    {
        public static void Initialize(IServiceProvider serviceProvider)
        {
            using (var context = new MvcMovieContext(
                serviceProvider.GetRequiredService<
                    DbContextOptions<MvcMovieContext>>()))
            {
                // Look for any movies.
                if (context.Movie.Any())
                {
                    return;   // DB has been seeded
                }

                context.Movie.AddRange(
                    new Movie
                    {
                        Title = "Other Side of Heaven",
                        ReleaseDate = DateTime.Parse("1989-2-12"),
                        Genre = "Drama",
                        Price = 14.00M,
                        Rating = "G",
                        Image = "https://m.media-amazon.com/images/M/MV5BMjIyMDJkNzYtOTlhYy00ZGQzLWI0MjctMjA3MGFmZTc0ZmQ5XkEyXkFqcGdeQXVyMTk3NDI2Njc@._V1_.jpg"
                    },
                    new Movie
                    {
                        Title = "Angels Among Us",
                        ReleaseDate = DateTime.Parse("2008-3-12"),
                        Genre = "Musical",
                        Price = 17.00M,
                        Rating = "G",
                        Image = "https://d2jc79253juilm.cloudfront.net/product-images/000/736/978/detail/Angels_among_Us-CD-Tab.jpg?1572467466"
                    },
                    new Movie
                    {
                        Title = "The Saratov Approach",
                        ReleaseDate = DateTime.Parse("2010-9-15"),
                        Genre = "Drama",
                        Price = 19.00M,
                        Rating = "PG",
                        Image = "https://upload.wikimedia.org/wikipedia/en/thumb/0/08/The_Saratov_Approach_DVD_Cover.jpg/220px-The_Saratov_Approach_DVD_Cover.jpg"
                    }
                );
                context.SaveChanges();
            }
        }
    }
}