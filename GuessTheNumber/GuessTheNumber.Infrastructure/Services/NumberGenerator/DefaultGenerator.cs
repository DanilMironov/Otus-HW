using GuessTheNumber.Domain.Models.Settings;
using GuessTheNumber.Domain.Services.NumberGenerator;

namespace GuessTheNumber.Infrastructure.Services.NumberGenerator;

public class DefaultGenerator : INumberGenerator
{
    private IGameSettings _settings;
    private int? _currentNumber;

    public DefaultGenerator(IGameSettings settings)
    {
        _settings = settings;
    }
    
    public int GetTargetNumber()
    {
        return _currentNumber ?? throw new InvalidOperationException("Целевое число еще не сгенерировано");
    }

    public void GenerateNewNumber()
    {
        if (_settings.From > _settings.To) throw new ArgumentException("Некорректный диапазон");
        _currentNumber = new Random().Next(_settings.From, _settings.To);
    }
}