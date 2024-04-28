using HW_Prototype.Interfaces;

namespace HW_Prototype.Models.Abstract;

/// <summary>
/// Базовый класс растений
/// </summary>
public abstract class Plant : IMyCloneable<Plant>
{
    /// <summary>
    /// Название растения
    /// </summary>
    public string Title { get; }

    protected Plant(string title)
    {
        Title = title;
    }

    public abstract Plant CustomClone();
}