namespace HW_Prototype.Models;

/// <summary>
/// Корнеплод
/// </summary>
public class RootVegetable : Vegetable, ICloneable
{
    public RootVegetable(string title) : base(title) { }
    
    /// <summary>
    /// Метод клонирования интерфейса ICloneable
    /// </summary>
    /// <returns></returns>
    public object Clone()
    {
        return CustomClone();
    }

    public override RootVegetable CustomClone()
    {
        return new RootVegetable(Title);
    }
}