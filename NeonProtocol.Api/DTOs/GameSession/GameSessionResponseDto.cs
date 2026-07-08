namespace NeonProtocol.Api.DTOs.GameSession;

public class GameSessionResponseDto
{
    public int Id { get; set; }

    public int Score { get; set; }

    public int Kills { get; set; }

    public int LevelReached { get; set; }

    public int DamageTaken { get; set; }

    public int SurvivalTime { get; set; }

    public int StageReached { get; set; }

    public int WaveReached { get; set; }

    public DateTime CreatedAt { get; set; }
}