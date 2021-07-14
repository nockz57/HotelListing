using HotelListingAPI.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HotelListingAPI.Configurations.Entities
{
    public class CountryConfiguration : IEntityTypeConfiguration<Country>
    {
        public void Configure(EntityTypeBuilder<Country> builder)
        {
            builder.HasData(
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
                },
                new Country
                {
                    Id = 4,
                    Name = "Tanzania",
                    ShortName = "TZ"
                },
                new Country
                {
                    Id = 5,
                    Name = "Mauritius",
                    ShortName = "MUS"
                }
           );
        }
    }
}
