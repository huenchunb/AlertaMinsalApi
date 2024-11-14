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

        builder.Property(e => e.Name)
            .IsRequired(false);

        builder.Property(e => e.LastName)
            .IsRequired(false);

        builder.Property(e => e.FullName)
            .IsRequired(false);

        builder.Property(e => e.Rut)
            .IsRequired(false);

        builder.Property(e => e.Digito)
            .IsRequired(false);

        builder.Property(e => e.RutNormalized)
            .IsRequired(false);

        builder.Property(e => e.Direccion)
            .IsRequired(false);

        builder.Property(e => e.ComunaId)
            .IsRequired(false);

        builder.Property(e => e.TipoAgresorId)
            .IsRequired();
    }
}
