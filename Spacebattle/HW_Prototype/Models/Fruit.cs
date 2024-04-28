using HW_Prototype.Models.Abstract;

namespace HW_Prototype.Models;

/// <summary>
/// Фрукты
/// </summary>
public class Fruit : Plant
{
    public Fruit(string title) : base(title) { }

    public override Fruit CustomClone()
    {
        return new Fruit(Title);
    }
}