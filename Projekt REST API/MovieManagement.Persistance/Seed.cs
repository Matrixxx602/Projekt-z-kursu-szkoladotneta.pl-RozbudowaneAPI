using Microsoft.EntityFrameworkCore;
using MovieManagement.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace MovieManagement.Persistance
{
    public static class Seed
    {
        public static void SeedData(this ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Director>(d =>
            {
                d.HasData(new Director()
                {
                    Id = 1,
                    StatusId = 1,
                    Created = DateTime.Now
                });

                d.OwnsOne(d => d.DirectorName).HasData(new { DirectorId = 1, FirstName = "Andrzej", LastName = "Wajda" });
            });

            modelBuilder.Entity<Movie>().HasData(
                new Movie() { DirectorId = 1, Id = 1, Name = "Pan Tadeusz" },
                new Movie() { DirectorId = 1, Id = 2, Name = "Popiół i Diament" }
                );
        }
    }
}
