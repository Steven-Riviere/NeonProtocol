using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using NeonProtocol.Api.Entities;

public class PlayerConfiguration : IEntityTypeConfiguration<Player>
{
    public void Configure(EntityTypeBuilder<Player> builder)
    {
        builder.HasKey(p => p.Id);
        builder.Property(p => p.Pseudo)
            .IsRequired()
            .HasMaxLength(13);

        builder.HasIndex(p => p.Pseudo)
            .IsUnique();
    }
}