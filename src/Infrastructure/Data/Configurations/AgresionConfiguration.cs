using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using WebApiAlertaMinsal.Domain.Entities;

namespace WebApiAlertaMinsal.Infrastructure.Data.Configurations;

public class AgresionConfiguration : IEntityTypeConfiguration<Agresion>
{
    public void Configure(EntityTypeBuilder<Agresion> builder)
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

        builder.Property(e => e.FechaAgresion)
            .IsRequired()
            .HasDefaultValue(DateTime.Now);

        builder.Property(e => e.EmpleadoId)
            .IsRequired();

        builder.HasMany(e => e.AgresionTestigos)
            .WithOne(e => e.Agresion)
            .HasForeignKey(e => e.AgresionId)
            .OnDelete(DeleteBehavior.Restrict);

        builder.HasMany(e => e.TipoAgresionCategorias)
            .WithOne(e => e.Agresion)
            .HasForeignKey(e => e.AgresionId)
            .OnDelete(DeleteBehavior.Restrict);

        builder.HasMany(e => e.Agresores)
            .WithOne(e => e.Agresion)
            .HasForeignKey(e => e.AgresionId)
            .OnDelete(DeleteBehavior.Restrict);
    }
}
