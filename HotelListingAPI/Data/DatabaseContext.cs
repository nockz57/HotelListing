using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HotelListingAPI.Data
{
    public class DatabaseContext : DbContext
    {
        public DatabaseContext(DbContextOptions options) : base (options)
        {}
        public DbSet<Country> Countries { get; set; }
        public DbSet<Hotel> Hotels { get; set; }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            builder.Entity<Country>().HasData(
                new Country
                {
                    Id = 1,
                    Name = "South Africa",
                    ShortName = "ZA"
                },
                new Country
                {
                    Id = 2,
                    Name = "Zimbabwe",
                    ShortName = "ZW"
                },
                new Country
                {
                    Id = 3,
                    Name = "Mozambique",
                    ShortName = "MZ"
                }
                );

            builder.Entity<Hotel>().HasData(
                new Hotel
                {
                    Id = 1,
                    Name = "Polana Serena",
                    Address = "1380 Av. Julius Nyerere, Maputo",
                    CountryId = 3,
                    Rating = 4.7
                },
                new Hotel
                {
                    Id = 2,
                    Name = "Central Lodge",
                    Address = "Johannesburg",
                    CountryId = 1,
                    Rating = 3.7
                },
                new Hotel
                {
                    Id = 3,
                    Name = "The Victoria Falls",
                    Address = "1 Mallet Dr",
                    CountryId = 2,
                    Rating = 5
                }
                );
        }


    }
}
