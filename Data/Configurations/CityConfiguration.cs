using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using CityBreaks.Web.Models;

namespace CityBreaks.Web.Data.Configurations
{
    public class CityConfiguration : IEntityTypeConfiguration<City>
    {
        public void Configure(EntityTypeBuilder<City> builder)
        {
            builder.HasKey(c => c.Id);

            builder.Property(c => c.Name)
                .HasColumnName("city_name")
                .HasMaxLength(100)
                .IsRequired();

            builder.Property(c => c.CountryId)
                .HasColumnName("country_id")
                .IsRequired();

            builder.HasMany(c => c.Properties)
                .WithOne(p => p.City)
                .HasForeignKey(p => p.CityId)
                .OnDelete(DeleteBehavior.Cascade);
            builder.HasData(
                // Cidades do Brasil (CountryId = 1)
                new City { Id = 1, Name = "São Paulo", CountryId = 1 },
                new City { Id = 2, Name = "Rio de Janeiro", CountryId = 1 },
                new City { Id = 3, Name = "Salvador", CountryId = 1 },

                // Cidades dos Estados Unidos (CountryId = 2)
                new City { Id = 4, Name = "New York", CountryId = 2 },
                new City { Id = 5, Name = "Los Angeles", CountryId = 2 },
                new City { Id = 6, Name = "Miami", CountryId = 2 },

                // Cidades da França (CountryId = 3)
                new City { Id = 7, Name = "Paris", CountryId = 3 },
                new City { Id = 8, Name = "Nice", CountryId = 3 },

                // Cidades da Itália (CountryId = 4)
                new City { Id = 9, Name = "Roma", CountryId = 4 },
                new City { Id = 10, Name = "Milão", CountryId = 4 },

                // Cidades da Espanha (CountryId = 5)
                new City { Id = 11, Name = "Madrid", CountryId = 5 },
                new City { Id = 12, Name = "Barcelona", CountryId = 5 }
            );
        }
    }
}