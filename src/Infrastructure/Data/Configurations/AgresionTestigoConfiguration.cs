using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using WebApiAlertaMinsal.Domain.Entities;

namespace WebApiAlertaMinsal.Infrastructure.Data.Configurations;

public class AgresionTestigoConfiguration : IEntityTypeConfiguration<AgresionTestigo>
{
    public void Configure(EntityTypeBuilder<AgresionTestigo> builder)
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

        builder.Property(e => e.TestigoId)
            .IsRequired();
    }
}
