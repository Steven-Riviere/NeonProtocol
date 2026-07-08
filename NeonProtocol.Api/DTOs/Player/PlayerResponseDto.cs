namespace NeonProtocol.Api.DTOs.Player;

public class PlayerResponseDto
{
    public int Id { get; set; }

    public string Pseudo { get; set; } = string.Empty;

    public DateTime CreatedAt { get; set; }
}