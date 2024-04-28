using HW_Prototype.Models.Abstract;

namespace HW_Prototype.Models;

/// <summary>
/// Овощи
/// </summary>
public class Vegetable : Plant
{
    public Vegetable(string title) : base(title) {}

    public override Vegetable CustomClone()
    {
        return new Vegetable(Title);
    }
}