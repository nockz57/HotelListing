using HotelListingAPI.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HotelListingAPI.Configurations.Entities
{
    public class HotelConfiguration : IEntityTypeConfiguration<Hotel>
    {
        public void Configure(EntityTypeBuilder<Hotel> builder)
        {
            builder.HasData(
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
                },
                new Hotel
                {
                    Id = 4,
                    Name = "Baraza Resort & Spa",
                    Address = "Zanzibar-Bwejuu",
                    CountryId = 4,
                    Rating = 4.5
                },
                new Hotel
                {
                    Id = 5,
                    Name = "Grand Gaube",
                    Address = "North Coast",
                    CountryId = 5,
                    Rating = 5
                }
                );
        }
    }
}
