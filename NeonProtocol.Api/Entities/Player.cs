namespace NeonProtocol.Api.Entities;

public class Player
{
    public int Id { get; set; }
    public string Pseudo { get; set; } = string.Empty;

    public List<GameSession> GameSessions { get; set; } = new ();

    public DateTime CreatedAt { get; set; } = DateTime.UtcNow;
}