using MovieManagement.Domain.Entities;
using MovieManagement.Persistance;
using System.Collections.Generic;
using System;
using System.Threading.Tasks;
using System.Net.Http;
using Newtonsoft.Json;

namespace WebApi.IntegrationTests.Common
{
    public class Utilities
    {
        public static async Task<T> GetResponseContent<T>(HttpResponseMessage response)
        {
            var stringResponse = await response.Content.ReadAsStringAsync();

            var result = JsonConvert.DeserializeObject<T>(stringResponse);
            return result;
        }
        public static void InitilizeDbForTests(MovieDbContext context)
        {
            var director = new MovieManagement.Domain.Entities.Director() { Id = 2, StatusId = 1, DirectorName = new MovieManagement.Domain.ValueObjects.PersonName() { FirstName = "Kajetan", LastName = "Duszyński" } };
            context.Directors.Add(director);

            var directorBiography = new DirectorBiography() { DirectorId = 2, Id = 2, DoB = new DateTime(1950, 1, 1), PlaceOfBirth = "Warsaw" };
            context.DirectorBiographies.Add(directorBiography);

            var genre = new Genre() { Id = 1, Name = "Comedy" };
            context.Genres.Add(genre);

            var movie = new Movie() { DirectorId = 2, Genres = new List<Genre>() { genre }, Name = "MovieName", PremiereYear = 2000, Id = 3 };

            context.Movies.Add(movie);

            context.SaveChanges();
        }
    }
}
