namespace GuessTheNumber.Domain.Services.Comparer;

public interface INumberComparer
{
    /// <summary>
    /// Сравнивает два числа 
    /// </summary>
    /// <param name="targetValue">Загаданное число</param>
    /// <param name="userValue">Число введенное пользователем</param>
    /// <returns>-1, если введенное число меньше загаданного,
    /// 0, если числа равны, 1, если введенное число больше загаданного</returns>
    int Compare(int userValue, int targetValue);
}