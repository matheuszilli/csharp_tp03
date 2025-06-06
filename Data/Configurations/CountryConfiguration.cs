using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using CityBreaks.Web.Models;

namespace CityBreaks.Web.Data.Configurations
{
    public class CountryConfiguration : IEntityTypeConfiguration<Country>
    {
        public void Configure(EntityTypeBuilder<Country> builder)
        {
            builder.HasKey(c => c.Id);

            builder.Property(c => c.CountryCode)
                .HasColumnName("country_code")     
                .HasMaxLength(3)                  
                .IsRequired();                    

            builder.Property(c => c.CountryName)
                .HasColumnName("country_name") 
                .HasMaxLength(100)
                .IsRequired();

            builder.HasMany(c => c.Cities)
                .WithOne(city => city.Country)
                .HasForeignKey(city => city.CountryId)
                .OnDelete(DeleteBehavior.Cascade);


            builder.HasData(
                new Country
                {
                    Id = 1,
                    CountryCode = "BR",
                    CountryName = "Brasil"
                },
                new Country
                {
                    Id = 2,
                    CountryCode = "US",
                    CountryName = "Estados Unidos"
                },
                new Country
                {
                    Id = 3,
                    CountryCode = "FR",
                    CountryName = "França"
                },
                new Country
                {
                    Id = 4,
                    CountryCode = "IT",
                    CountryName = "Itália"
                },
                new Country
                {
                    Id = 5,
                    CountryCode = "ES",
                    CountryName = "Espanha"
                }
            );
        }
    }
}