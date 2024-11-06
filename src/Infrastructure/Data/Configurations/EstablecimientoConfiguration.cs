using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using WebApiAlertaMinsal.Domain.Entities;

namespace WebApiAlertaMinsal.Infrastructure.Data.Configurations;

public class EstablecimientoConfiguration : IEntityTypeConfiguration<Establecimiento>
{
    public void Configure(EntityTypeBuilder<Establecimiento> builder)
    {
        builder.HasKey(e => e.Id);

        builder.Property(e => e.Id)
            .ValueGeneratedNever();

        builder.Property(e => e.Name)
            .HasMaxLength(200)
            .IsRequired();

        builder.Property(e => e.TipoEstablecimientoId)
            .IsRequired();

        builder.Property(e => e.NivelEstablecimientoId)
            .IsRequired();

        builder.Property(e => e.Address)
            .HasMaxLength(200)
            .IsRequired();

        builder.Property(e => e.StreetNumber)
            .HasMaxLength(100)
            .IsRequired();

        builder.Property(e => e.PhoneNumber)
            .IsRequired();

        builder.Property(e => e.Urgency)
            .IsRequired()
            .HasDefaultValue(false);

        builder.Property(e => e.TipoUrgenciaEstablecimientoId)
            .IsRequired();

        builder.Property(e => e.Longitude)
            .IsRequired();

        builder.Property(e => e.Latitude)
            .IsRequired();

        builder.Property(e => e.ComplejidadEstablecimientoId)
            .IsRequired();

        builder.Property(e => e.TipoAtencionEstablecimientoId)
            .IsRequired();

        builder.Property(e => e.ComunaId)
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
    }
}
