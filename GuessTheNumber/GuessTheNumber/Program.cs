using GuessTheNumber.Infrastructure.Services.Comparer;
using GuessTheNumber.Infrastructure.Services.Configurator;
using GuessTheNumber.Infrastructure.Services.Game;
using GuessTheNumber.Infrastructure.Services.NumberGenerator;
using GuessTheNumber.Infrastructure.Settings;

namespace GuessTheNumber;

public static class Program
{
    public static void Main()
    {
        var configurator = new DefaultConfigurator();
        var settings = configurator.GetSettings("settings.json");

        var generator = new DefaultGenerator(settings);
        var comparer = new DefaultNumberComparer();

        var game = new GameMachine(comparer, generator, settings);
        game.StartGame();
    }
}