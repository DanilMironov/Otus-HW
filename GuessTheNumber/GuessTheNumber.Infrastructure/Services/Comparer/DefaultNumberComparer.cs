using GuessTheNumber.Domain.Services.Comparer;

namespace GuessTheNumber.Infrastructure.Services.Comparer;

public class DefaultNumberComparer : INumberComparer
{
    public int Compare(int userValue, int targetValue)
    {
        if (userValue < targetValue) return -1;
        if (userValue > targetValue) return 1;
        return 0;
    }
}