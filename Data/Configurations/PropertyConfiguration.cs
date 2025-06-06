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
        }
    }
}