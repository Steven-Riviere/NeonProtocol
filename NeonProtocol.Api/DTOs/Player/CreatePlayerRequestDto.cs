using System.ComponentModel.DataAnnotations;

namespace NeonProtocol.Api.DTOs.Player;

public class CreatePlayerRequestDto
{
    [Required(ErrorMessage = "Le pseudo est obligatoire.")]
    [StringLength(13, MinimumLength = 3,
        ErrorMessage = "Le pseudo doit contenir entre 3 et 13 caractères.")]
    [RegularExpression(
        @"^[a-zA-Z0-9_]+$",
        ErrorMessage = "Le pseudo contient des caractères non autorisés.")]
    public string Pseudo { get; set; } = string.Empty;
}