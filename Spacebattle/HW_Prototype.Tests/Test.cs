using HW_Prototype.Models;

namespace HW_Prototype.Tests;

public class Test
{
    [Fact]
    public void CloneMethodTest()
    {
        // Arrange
        // Инициируем объекты
        var carrot = new RootVegetable("Морковь");
        var blueberry = new Berry("Черника");
        
        // Act
        // Клонируем встроенным методом
        var carrotClone = (RootVegetable)carrot.Clone();
        var blueberryClone = (Berry)blueberry.Clone();
        
        // Клонируем нашим методом
        var carrotMyClone = carrot.CustomClone();
        var blueberryMyClone = blueberry.CustomClone();
        
        // Assert
        Assert.Equal(carrot.Title, carrotClone.Title);
        Assert.Equal(carrot.Title, carrotMyClone.Title);
        Assert.Equal(blueberry.Title, blueberryClone.Title);
        Assert.Equal(blueberry.Title, blueberryMyClone.Title);
        Assert.False(ReferenceEquals(carrot, carrotClone));
        Assert.False(ReferenceEquals(carrot, carrotMyClone));
        Assert.False(ReferenceEquals(blueberry, blueberryClone));
        Assert.False(ReferenceEquals(blueberry, blueberryMyClone));
        
        // ICloneable: лишний каст к типу -- метод Clone() возвращает object, который приходится приводить к более строгому типу
        // IMyCloneable: лишен недостатка приведения типов при клонировании
    }
}