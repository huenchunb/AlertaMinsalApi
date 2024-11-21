using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using WebApiAlertaMinsal.Domain.Entities;

namespace WebApiAlertaMinsal.Infrastructure.Data.Configurations;

public class AgresionCategoriaConfiguration : IEntityTypeConfiguration<AgresionCategoria>
{
    public void Configure(EntityTypeBuilder<AgresionCategoria> builder)
    {
        builder.HasKey(ac => new { ac.AgresionId, ac.CategoriaAgresionId });

        builder.Property(e => e.AgresionId).IsRequired();
        builder.Property(e => e.CategoriaAgresionId).IsRequired();
    }
}
