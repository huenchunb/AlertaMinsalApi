using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using WebApiAlertaMinsal.Domain.Entities;

namespace WebApiAlertaMinsal.Infrastructure.Data.Configurations;

public class ComunaConfiguration : IEntityTypeConfiguration<Comuna>
{
    public void Configure(EntityTypeBuilder<Comuna> builder)
    {
        builder.HasKey(e => e.Id);

        builder.Property(e => e.Id)
            .ValueGeneratedNever();

        builder.Property(e => e.Created)
            .IsRequired()
            .HasDefaultValue(DateTimeOffset.Now);

        builder.Property(e => e.CreatedBy)
            .IsRequired(false);

        builder.Property(e => e.LastModified)
            .IsRequired()
            .HasDefaultValue(DateTimeOffset.Now);

        builder.Property(e => e.LastModifiedBy)
            .IsRequired(false);

        builder.Property(e => e.Name)
            .HasMaxLength(100)
            .IsRequired();

        builder.HasIndex(e => e.Name)
            .IsUnique();

        builder.Property(e => e.IdRegion)
            .IsRequired();

        builder.HasMany(e => e.Establecimientos)
            .WithOne(e => e.Comuna)
            .HasForeignKey(e => e.ComunaId)
            .OnDelete(DeleteBehavior.Restrict);

        builder.HasMany(e => e.Agresores)
            .WithOne(e => e.Comuna)
            .HasForeignKey(e => e.ComunaId)
            .OnDelete(DeleteBehavior.Restrict);

        builder.HasMany(e => e.Empleados)
            .WithOne(e => e.Comuna)
            .HasForeignKey(e => e.ComunaId)
            .OnDelete(DeleteBehavior.Restrict);
    }
}
