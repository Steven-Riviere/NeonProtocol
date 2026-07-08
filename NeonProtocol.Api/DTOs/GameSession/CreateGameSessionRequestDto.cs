using System.ComponentModel.DataAnnotations;

namespace NeonProtocol.Api.DTOs.GameSession;

public class CreateGameSessionRequestDto
{
    public int PlayerId { get; set; }

    [Range(0, 9999999,
        ErrorMessage = "Le score ne peut pas être négatif.")]
    public int Score { get; set; }

    [Range(0, 9999999,
        ErrorMessage = "Le nombre de kills ne peut pas être négatif.")]
    public int Kills { get; set; }

   [Range(0, 150,
        ErrorMessage = "Le niveau atteint est invalide.")]
    public int LevelReached { get; set; }


    [Range(0, 9999999,
        ErrorMessage = "Les dégâts reçus ne peuvent pas être négatifs.")]
    public int DamageTaken { get; set; }


    [Range(0, int.MaxValue,
        ErrorMessage = "Le temps de survie ne peut pas être négatif.")]
    public int SurvivalTime { get; set; }


    [Range(0, int.MaxValue,
        ErrorMessage = "L'étape atteinte est invalide.")]
    public int StageReached { get; set; }


    [Range(0, int.MaxValue,
        ErrorMessage = "La vague atteinte est invalide.")]
    public int WaveReached { get; set; }
}