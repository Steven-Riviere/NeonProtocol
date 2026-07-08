namespace NeonProtocol.Api.DTOs.GameSession;

public class LeaderboardEntryDto
{
    public string Pseudo { get; set; } = string.Empty;

    public int Score { get; set; }

    public int LevelReached { get; set; }

    public DateTime CreatedAt { get; set; }
}