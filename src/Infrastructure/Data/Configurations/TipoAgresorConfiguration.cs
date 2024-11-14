using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using WebApiAlertaMinsal.Domain.Entities;

namespace WebApiAlertaMinsal.Infrastructure.Data.Configurations;

public class TipoAgresorConfiguration : IEntityTypeConfiguration<TipoAgresor>
{
    public void Configure(EntityTypeBuilder<TipoAgresor> builder)
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
            .HasMaxLength(100)
            .IsRequired();

        builder.HasIndex(e => e.Name)
            .IsUnique();

        builder.HasMany(e => e.Agresores)
            .WithOne(e => e.TipoAgresor)
            .HasForeignKey(e => e.TipoAgresorId)
            .OnDelete(DeleteBehavior.Restrict);
    }
}
