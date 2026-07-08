namespace NeonProtocol.Api.Entities;

public class GameSession
{
    public int Id { get; set; }
    public int PlayerId { get; set; }  

    public Player Player { get; set; } = null!;

    public int Score { get; set; }
    public int Kills { get; set; }
    public int LevelReached { get; set; }
    public int DamageTaken { get; set; }
    public int SurvivalTime { get; set; }
    public int StageReached { get; set; }
    public int WaveReached { get; set; }
    
    public DateTime CreatedAt { get; set; } = DateTime.UtcNow;
}