namespace HW_Prototype.Models;

/// <summary>
/// Ягода
/// </summary>
public class Berry : Fruit, ICloneable
{
    public Berry(string title) : base(title) { }

    /// <summary>
    /// Метод клонирования интерфейса ICloneable
    /// </summary>
    /// <returns></returns>
    public object Clone()
    {
        return CustomClone();
    }

    public override Berry CustomClone()
    {
        return new Berry(Title);
    }
}