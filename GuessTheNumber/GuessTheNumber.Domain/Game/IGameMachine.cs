using GuessTheNumber.Domain.Models.Settings;

namespace GuessTheNumber.Domain.Game;

public interface IGameMachine
{
    /// <summary>
    /// Начинает процесс игры
    /// </summary>
    void StartGame();
}