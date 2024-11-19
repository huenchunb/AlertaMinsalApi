using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using WebApiAlertaMinsal.Domain.Entities;

namespace WebApiAlertaMinsal.Infrastructure.Data.Configurations;

public class AgresorConfiguration : IEntityTypeConfiguration<Agresor>
{
    public void Configure(EntityTypeBuilder<Agresor> builder)
    {
        builder.HasKey(e => e.Id);

        builder.Property(e => e.Id)
            .ValueGeneratedOnAdd()
            .UseIdentityColumn();

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

        builder.Property(e => e.AgresionId)
            .IsRequired();

        builder.Property(e => e.Name)
            .HasMaxLength(100)
            .IsRequired();

        builder.Property(e => e.LastName)
            .HasMaxLength(100)
            .IsRequired();

        builder.Property(e => e.FullName)
            .HasMaxLength(200)
            .IsRequired();

        builder.Property(e => e.Rut)
            .HasMaxLength(8)
            .IsRequired();

        builder.Property(e => e.Digito)
            .HasMaxLength(1)
            .IsRequired();

        builder.Property(e => e.RutNormalized)
            .HasMaxLength(50)
            .IsRequired();

        builder.HasIndex(e => e.RutNormalized)
            .IsUnique();

        builder.Property(e => e.Direccion)
            .IsRequired();

        builder.Property(e => e.ComunaId)
            .IsRequired();

        builder.Property(e => e.TipoAgresorId)
            .IsRequired();
    }
}
