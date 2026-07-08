using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using NeonProtocol.Api.Entities;

public class GameSessionConfiguration : IEntityTypeConfiguration<GameSession>
{
    public void Configure(EntityTypeBuilder<GameSession> builder)
    {
        builder.Property(g => g.Score)
            .IsRequired();

        builder.Property(g => g.Kills)
            .IsRequired();

        builder.Property(g => g.LevelReached)
            .IsRequired();

        builder.Property(g => g.DamageTaken)
            .IsRequired();

        builder.Property(g => g.SurvivalTime)
            .IsRequired();

        builder.Property(g => g.StageReached)
            .IsRequired();

        builder.Property(g => g.WaveReached)
            .IsRequired();
    }
}