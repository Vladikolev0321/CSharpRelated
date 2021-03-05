using NUnit.Framework;

[TestFixture]
public class DummyTests
{
    [Test]
    public void DummyShouldLoseHealth()
    {
        //Arrange  
        var dummy = new Dummy(100, 200);

        //Act
        dummy.TakeAttack(50);

        //Assert
        Assert.That(dummy.Health, Is.EqualTo(50));
    }
    [Test]
    public void DeadDummyShouldThrowExceptionIfAttacked()
    {
        //Arrange
        var dummy = new Dummy(0, 200);       

        //Assert
        Assert.That(() => dummy.TakeAttack(50),//Act
            Throws.InvalidOperationException.With.Message.EqualTo("Dummy is dead.")
        );
    }
    [Test]
    public void DeadDummyShouldGiveExperience()
    {
        //Arrange
        var dummy = new Dummy(0, 200);

        //Act
        var experience = dummy.GiveExperience();

        //Assert
        Assert.That(experience, Is.EqualTo(200));
    }
    [Test]
    public void DummyShouldNotGiveExperienceIfDead()
    {
        //Arrange
        var dummy = new Dummy(100, 200);

        //Assert
        Assert.That(() => dummy.GiveExperience(),//Act
            Throws.InvalidOperationException.With.Message.EqualTo("Target is not dead."));
    }
}
