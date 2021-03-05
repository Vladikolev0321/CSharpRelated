using NUnit.Framework;
using System;

[TestFixture]
public class AxeTests
{
    [Test]
    public void AxeShouldLooseDurabilityAfterAttack()
    {
        //Arrange
        var axe = new Axe(10, 5);
        var target = new Dummy(100, 500);
        //Act
        axe.Attack(target);

        //Assert
        Assert.That(axe.DurabilityPoints, Is.EqualTo(4));

    }
    [Test]
    public void AxeShouldThrowExceptionIfAttackIsMadeWithBrokenWeapon()
    {
        //Arrange
        var axe = new Axe(10, 0);
        var target = new Dummy(100, 500);
        
       

        //Assert
        Assert.That(() => axe.Attack(target),//Act
            Throws.InvalidOperationException
            .With.Message.EqualTo("Axe is broken."));
    }
}