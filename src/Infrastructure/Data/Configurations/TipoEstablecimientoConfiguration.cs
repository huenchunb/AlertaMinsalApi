using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using WebApiAlertaMinsal.Domain.Entities;

namespace WebApiAlertaMinsal.Infrastructure.Data.Configurations;

public class TipoEstablecimientoConfiguration : IEntityTypeConfiguration<TipoEstablecimiento>
{
    public void Configure(EntityTypeBuilder<TipoEstablecimiento> builder)
    {
        builder.HasKey(e => e.Id);

        builder.Property(e => e.Id)
            .ValueGeneratedOnAdd();

        builder.Property(e => e.Name)
            .HasMaxLength(100)
            .IsRequired();

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

        builder.HasIndex(e => e.Name)
            .IsUnique();

        builder.HasMany(e => e.Establecimientos)
            .WithOne(e => e.TipoEstablecimiento)
            .HasForeignKey(e => e.TipoEstablecimientoId)
            .OnDelete(DeleteBehavior.Restrict);
    }
}
