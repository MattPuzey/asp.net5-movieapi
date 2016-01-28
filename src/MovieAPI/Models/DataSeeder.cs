using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.Data.Entity;
using Microsoft.Extensions.DependencyInjection;

namespace MovieAPI.Models
{
    public static class DataSeeder
    {
        public static void Initialize(IServiceProvider serviceProvider)
        {
            var context = serviceProvider.GetService<MoviesAppContext>();
            context.Database.Migrate();
            if (!context.Movies.Any())
            {
                var movieOne = new Movie() { Title = " Star Wars: Force Awakens", Director = "JJ Abrams", TicketPrice = 7 };
                var movieTwo = new Movie() { Title = "The Revenant", Director = "Alejandro Iñárritu ", TicketPrice = 8 };
                var movieThree = new Movie() { Title = "The Hateful Eight", Director = "Quentin Tarantino ", TicketPrice = 7 };
                var movieFour = new Movie() { Title = "Jurassic World", Director = "Colin Trevorrow", TicketPrice = 6 };
                var movieFive = new Movie() { Title = "Avengers: Age of Ultron", Director = "Joss Whedon", TicketPrice = 7 };
                var movieSix = new Movie() { Title = "Ant-man", Director = "Peyton Reed", TicketPrice = 7 };
                var movieSeven = new Movie() { Title = "Interstellar", Director = "Christopher Nolan", TicketPrice = 7 };


                context.Movies.AddRange(
                        movieOne, movieTwo, movieThree, movieFour, movieFive, movieSix, movieSeven
                        );
                context.SaveChanges();
            }

        }

    }
}

