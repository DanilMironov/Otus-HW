using GuessTheNumber.Domain.Models.Settings;
using GuessTheNumber.Domain.Services.Configuration;
using GuessTheNumber.Infrastructure.Settings;
using Microsoft.Extensions.Configuration;

namespace GuessTheNumber.Infrastructure.Services.Configurator;

public class DefaultConfigurator : IConfigurator
{
    public IGameSettings GetSettings(string configPath)
    {
        var config = new ConfigurationBuilder()
            .AddJsonFile(configPath, true, true)
            .Build();

        var settings = config
            .GetSection("Settings")
            .Get<DefaultGameSettings>();

        return settings ?? throw new IOException("Не удалось прочитать файл настроек");
    }
}