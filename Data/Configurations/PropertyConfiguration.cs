using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using CityBreaks.Web.Models;
using CityBreaks.Models;

namespace CityBreaks.Web.Data.Configurations
{
    public class PropertyConfiguration : IEntityTypeConfiguration<Property>
    {
        public void Configure(EntityTypeBuilder<Property> builder)
        {
            builder.HasKey(p => p.Id);

            builder.Property(p => p.Name)
                .HasColumnName("property_name")
                .HasMaxLength(200)
                .IsRequired();

            builder.Property(p => p.PricePerNight)
                .HasColumnName("price_per_night")
                .HasColumnType("decimal(10,2)")
                .IsRequired();

            builder.Property(p => p.CityId)
                .HasColumnName("city_id")
                .IsRequired();

            builder.HasData(
                // Propriedades em São Paulo (CityId = 1)
                new Property { Id = 1, Name = "Hotel Paulistano", PricePerNight = 850.00m, CityId = 1 },
                new Property { Id = 2, Name = "Pousada Cóe Velhote", PricePerNight = 280.00m, CityId = 1 },

                // Propriedades no Rio de Janeiro (CityId = 2)
                new Property { Id = 3, Name = "Hotel Copacabana", PricePerNight = 1200.00m, CityId = 2 },
                new Property { Id = 4, Name = "Apartamento em Take a Fire (Botafogo)", PricePerNight = 450.00m, CityId = 2 },

                // Propriedades em New York (CityId = 4)
                new Property { Id = 5, Name = "The Plaza Hotel", PricePerNight = 2500.00m, CityId = 4 },
                new Property { Id = 6, Name = "Brooklyn Apartment", PricePerNight = 180.00m, CityId = 4 },

                // Propriedades em Paris (CityId = 7)
                new Property { Id = 7, Name = "Hotel França", PricePerNight = 1800.00m, CityId = 7 },
                new Property { Id = 8, Name = "Apartamento Torre", PricePerNight = 320.00m, CityId = 7 },

                // Propriedades em Roma (CityId = 9)
                new Property { Id = 9, Name = "Hotel de Italia", PricePerNight = 1100.00m, CityId = 9 },
                new Property { Id = 10, Name = "B&B Centro Histórico", PricePerNight = 150.00m, CityId = 9 },

                // Propriedades em Barcelona (CityId = 12)
                new Property { Id = 11, Name = "Hotel Casa Fuster", PricePerNight = 480.00m, CityId = 12 },
                new Property { Id = 12, Name = "Apartamento Sagrada Família", PricePerNight = 95.00m, CityId = 12 }
            );
        }
    }
}