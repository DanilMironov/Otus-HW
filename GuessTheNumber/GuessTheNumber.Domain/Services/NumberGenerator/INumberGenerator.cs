namespace GuessTheNumber.Domain.Services.NumberGenerator;

public interface INumberGenerator
{
    /// <summary>
    /// Возвращает сгенерированное число 
    /// </summary>
    /// <returns></returns>
    int GetTargetNumber();
    
    /// <summary>
    /// Генерирует рандомное число в заданном диапазоне
    /// </summary>
    /// <param name="from">Нижний предел (невыколотый)</param>
    /// <param name="to">Верхний предел (выколотый)</param>
    /// <returns></returns>
    void GenerateNewNumber();
}