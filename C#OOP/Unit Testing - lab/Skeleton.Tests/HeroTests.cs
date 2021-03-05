using Moq;
using NUnit.Framework;
using Skeleton;

[TestFixture]
public class HeroTests
{
    [Test]
    public void HeroShouldGainXpIfTargetDies()
    {

        const int experience = 200; 
        //Arrange
        var fakeWeapon = Mock.Of<IWeapon>();


        var fakeTarget = new Mock<ITarget>();

        fakeTarget
            .Setup(t => t.IsDead())
            .Returns(true);

        fakeTarget
            .Setup(t => t.GiveExperience())
            .Returns(experience);

        var hero = new Hero("TestHero", fakeWeapon);

        //Act
        hero.Attack(fakeTarget.Object);

        //Assert
        Assert.That(hero.Experience, Is.EqualTo(experience));
    }
}