using GuessTheNumber.Domain.Game;
using GuessTheNumber.Domain.Models.Settings;
using GuessTheNumber.Domain.Services.Comparer;
using GuessTheNumber.Domain.Services.NumberGenerator;

namespace GuessTheNumber.Infrastructure.Services.Game;

public class GameMachine: IGameMachine
{
    private readonly INumberComparer _comparer;
    private readonly INumberGenerator _generator;
    private readonly IGameSettings _settings;
    
    public GameMachine(INumberComparer comparer, INumberGenerator generator, IGameSettings settings)
    {
        _comparer = comparer;
        _generator = generator;
        _settings = settings;
    }
    
    public void StartGame()
    {
        // количество попыток
        var currentTry = 0;
        // загадываем число
        _generator.GenerateNewNumber();
        // описываем правила игры
        Console.WriteLine($"Загадано число от {_settings.From} до {_settings.To}, " +
                          $"если угадаешь за {_settings.Attempts} попыток, ты выиграл.");
        // начало игры
        for (var i = 0; i < _settings.Attempts; i++)
        {
            Console.WriteLine("Введите ваше число");
            var userInput = GetUserInput();
            var comparisonResult = _comparer.Compare(userInput, _generator.GetTargetNumber());

            switch (comparisonResult)
            {
                case -1:
                    Console.WriteLine("Твое число меньше загаданного");
                    break;
                case 1:
                    Console.WriteLine("Твое число больше загаданного");
                    break;
                default:
                    Console.WriteLine("Ты угадал!");
                    return;
            }

            currentTry++;
        }
        Console.WriteLine($"Проигрыш!!! Было загадано число {_generator.GetTargetNumber()}.");
    }

    private int GetUserInput()
    {
        while (true)
        {
            var input = Console.ReadLine();
            if (int.TryParse(input, out var result))
            {
                return result;
            }
        }
    }
}