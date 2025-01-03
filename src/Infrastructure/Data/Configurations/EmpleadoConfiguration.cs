using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using WebApiAlertaMinsal.Domain.Entities;

namespace WebApiAlertaMinsal.Infrastructure.Data.Configurations;

public class EmpleadoConfiguration : IEntityTypeConfiguration<Empleado>
{
    public void Configure(EntityTypeBuilder<Empleado> builder)
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

        builder.Property(e => e.FirstName)
            .HasMaxLength(100)
            .IsRequired();

        builder.Property(e => e.LastName)
            .HasMaxLength(100)
            .IsRequired();

        builder.Property(e => e.FullName)
            .HasMaxLength(200)
            .IsRequired();

        builder.Property(e => e.Email)
            .HasMaxLength(254)
            .IsRequired();

        builder.HasIndex(e => e.Email)
            .IsUnique();

        builder.Property(e => e.PhoneNumber)
            .IsRequired();

        builder.Property(e => e.Address)
            .HasMaxLength(200)
            .IsRequired();

        builder.Property(e => e.StreetNumber)
            .HasMaxLength(50)
            .IsRequired();

        builder.Property(e => e.ComunaId)
            .IsRequired();

        builder.Property(e => e.ImageUrl)
            .HasMaxLength(2048);

        builder.Property(e => e.DateOfBirth)
            .IsRequired();

        builder.Property(e => e.AccountId)
            .HasMaxLength(36)
            .IsRequired();

        builder.HasIndex(e => e.AccountId)
            .IsUnique();

        builder.Property(e => e.MutualidadId)
            .IsRequired();

        builder.Property(e => e.EstamentoId)
            .IsRequired();

        builder.Property(e => e.EstablecimientoId)
            .IsRequired();

        builder.HasMany(e => e.Agresiones)
            .WithOne(e => e.Empleado)
            .HasForeignKey(e => e.EmpleadoId)
            .OnDelete(DeleteBehavior.Restrict);
    }
}
