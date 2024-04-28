namespace HW_Prototype.Interfaces;

public interface IMyCloneable<T>
{
    /// <summary>
    /// Клонировать
    /// </summary>
    T CustomClone();
}