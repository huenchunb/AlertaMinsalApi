using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using WebApiAlertaMinsal.Domain.Entities;

namespace WebApiAlertaMinsal.Infrastructure.Data.Configurations;

public class MutualidadConfiguration : IEntityTypeConfiguration<Mutualidad>
{
    public void Configure(EntityTypeBuilder<Mutualidad> builder)
    {
        builder.HasKey(e => e.Id);

        builder.Property(e => e.Id)
            .ValueGeneratedOnAdd()
            .UseIdentityColumn();

        builder.Property(e => e.Name)
            .IsRequired()
            .HasMaxLength(100);

        builder.HasIndex(e => e.Name)
            .IsUnique();

        builder.HasMany(e => e.Empleados)
            .WithOne(e => e.Mutualidad)
            .HasForeignKey(e => e.MutualidadId)
            .OnDelete(DeleteBehavior.Restrict);
    }
}
