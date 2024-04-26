using GuessTheNumber.Domain.Models.Settings;

namespace GuessTheNumber.Domain.Services.Configuration;

/// <summary>
/// Конфигуратор параметров игры 
/// </summary>
public interface IConfigurator
{
    /// <summary>
    /// Считывает конфигурацию по указанному пути
    /// </summary>
    /// <param name="configPath"></param>
    /// <returns></returns>
    IGameSettings GetSettings(string configPath);
}