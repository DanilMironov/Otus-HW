using GuessTheNumber.Domain.Models.Settings;

namespace GuessTheNumber.Infrastructure.Settings;

/// <summary>
/// Конфигурация игры
/// </summary>
public class DefaultGameSettings : IGameSettings
{
    public int Attempts { get; set; }
    public int From { get; set; }
    public int To { get; set; }
}