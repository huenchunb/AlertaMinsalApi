using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using WebApiAlertaMinsal.Domain.Entities;

namespace WebApiAlertaMinsal.Infrastructure.Data.Configurations;

public class AgresionTestigoConfiguration : IEntityTypeConfiguration<AgresionTestigo>
{
    public void Configure(EntityTypeBuilder<AgresionTestigo> builder)
    {
        builder.HasKey(e => new { e.AgresionId, e.TestigoId });

        builder.Property(e => e.AgresionId).IsRequired();

        builder.Property(e => e.TestigoId).IsRequired();
    }
}
