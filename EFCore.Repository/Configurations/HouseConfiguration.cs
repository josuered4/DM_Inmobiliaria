using BussinesObjects.Houses.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace EFCore.Repository.Configurations
{
    public class HouseConfiguration
    {
        public void Configure(EntityTypeBuilder<House> builder)
        {
            builder.HasKey(h => h.Id);

            builder.Property(h => h.Name)
                .IsRequired()
                .HasMaxLength(35)
                .IsFixedLength();

            builder.Property(h => h.Price)
                .IsRequired()
                .HasColumnType("decimal(18, 2)");

            builder.Property(h => h.Description)
                .HasMaxLength(350)
                .IsRequired();

            builder.Property(h => h.Amenities)
                .HasMaxLength(350)
                .IsRequired();

            builder.Property(h => h.Location)
                .HasMaxLength(150)
                .IsRequired();

            builder.Property(h => h.Levels)
                .IsRequired();

            builder.Property(h => h.LivingRoom)
                .IsRequired();

            builder.Property(h => h.Bathrooms)
                .HasAnnotation("MaxLength", 10);

            builder.Property(h => h.Garden)
                .IsRequired();

            builder.Property(h => h.Bedrooms)
                .HasAnnotation("MaxLength", 10);

            builder.Property(h => h.Kitchen)
                .IsRequired();

            builder.Property(h => h.ServiceYard)
                .IsRequired();

            builder.Property(h => h.ParkingLot)
                .IsRequired()
                .HasAnnotation("MaxLength", 10); ;
        }
    }
}
