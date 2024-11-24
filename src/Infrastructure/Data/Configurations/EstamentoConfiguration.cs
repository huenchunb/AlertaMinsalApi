using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using WebApiAlertaMinsal.Domain.Entities;

namespace WebApiAlertaMinsal.Infrastructure.Data.Configurations;

public class EstamentoConfiguration : IEntityTypeConfiguration<Estamento>
{
    public void Configure(EntityTypeBuilder<Estamento> builder)
    {
        builder.HasKey(e => e.Id);

        builder.Property(e => e.Id)
            .ValueGeneratedOnAdd()
            .UseIdentityColumn();

        builder.Property(e => e.Name)
            .IsRequired()
            .HasMaxLength(100);

        builder.Property(e => e.Grado)
            .IsRequired()
            .HasMaxLength(50);

        builder.HasIndex(e => e.Name)
            .IsUnique();

        builder.HasMany(e => e.Empleados)
            .WithOne(e => e.Estamento)
            .HasForeignKey(e => e.EstamentoId)
            .OnDelete(DeleteBehavior.Restrict);
    }
}
