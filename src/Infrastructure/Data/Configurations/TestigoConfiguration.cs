using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using WebApiAlertaMinsal.Domain.Entities;

namespace WebApiAlertaMinsal.Infrastructure.Data.Configurations;

public class TestigoConfiguration : IEntityTypeConfiguration<Testigo>
{
    public void Configure(EntityTypeBuilder<Testigo> builder)
    {
        builder.HasKey(e => e.Id);

        builder.Property(e => e.Id).ValueGeneratedOnAdd().UseIdentityColumn();

        builder.Property(e => e.Created).IsRequired().HasDefaultValue(DateTimeOffset.Now);

        builder.Property(e => e.CreatedBy).IsRequired(false);

        builder.Property(e => e.LastModified).IsRequired().HasDefaultValue(DateTimeOffset.Now);

        builder.Property(e => e.LastModifiedBy).IsRequired(false);

        builder.Property(e => e.Name).HasMaxLength(100).IsRequired();

        builder.Property(e => e.LastName).HasMaxLength(100).IsRequired();

        builder.Property(e => e.FullName).HasMaxLength(200).IsRequired();

        builder.Property(e => e.Rut).HasMaxLength(8).IsRequired();

        builder.Property(e => e.Digito).HasMaxLength(1).IsRequired();

        builder.Property(e => e.RutNormalized).HasMaxLength(50).IsRequired();

        builder.Property(e => e.Email).HasMaxLength(254).IsRequired();

        builder.Property(e => e.PhoneNumber).IsRequired();

        builder.HasMany(e => e.AgresionTestigos)
            .WithOne(e => e.Testigo)
            .HasForeignKey(e => e.TestigoId)
            .OnDelete(DeleteBehavior.Restrict);
    }
}
