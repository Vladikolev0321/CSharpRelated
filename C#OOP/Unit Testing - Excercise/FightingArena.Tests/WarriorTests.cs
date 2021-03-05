using FightingArena;
using NUnit.Framework;
using System;

namespace Tests
{
    public class WarriorTests
    {
        private Warrior warrior;
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void ConstructorShouldInicialise()
        {
            string name = "Vlado";
            int damage = 50;
            int health = 100;

            warrior = new Warrior(name, damage, health);

            Assert.AreEqual(name, warrior.Name);
            Assert.AreEqual(damage, warrior.Damage);
            Assert.AreEqual(health, warrior.HP);
        }
        //[TestCase(string str = Strin, 50, 100)]
        [TestCase("",50,100)]
        [TestCase("Vlado",0,100)]
        [TestCase("Vlado",-50,100)]
        [TestCase("Vlado",50,-100)]
        public void ConstructorShouldThrowExceptionIfGivenWrongArguments(string name,int damage,
            int hp)
        {
            Assert.Throws<ArgumentException>(() =>
            {
                warrior = new Warrior(name, damage, hp);
            });
        }
        [TestCase("Vlado", 50, 30)]
        [TestCase("Vlado", 50, 29)]
        public void AttackShouldThrowExceptionIfAttackersHpIsBelow30(string name, int damage,
            int hp)
        {
            warrior = new Warrior(name, damage, hp);
            Assert.Throws<InvalidOperationException>(() =>
            {
                warrior.Attack(new Warrior("Ivan", 10, 100));
            });
        }
        [TestCase("Toni", 50, 30)]
        [TestCase("Toni", 50, 29)]
        public void AttackShouldThrowExceptionIfTheattackedWarriorsHpIsBElow30(string name, int damage,
            int hp)
        {
            warrior = new Warrior("Vlado", 50, 100);
            Warrior attacked = new Warrior(name, damage, hp);

            Assert.Throws<InvalidOperationException>(() =>
            {
                warrior.Attack(attacked);
            });
        }
        [Test]
        public void AttackShouldThrowExceptionIfTheAttackedHaveMoreDamageThanTheAttacker()
        {
            warrior = new Warrior("Vlado", 50, 99);

            Assert.Throws<InvalidOperationException>(() =>
            {
                warrior.Attack(new Warrior("Toni", 100, 100));
            });
        }
        [Test]
        public void AttackShouldLowerTheirHealth()
        {
            warrior = new Warrior("Vlado", 50, 100);
            Warrior attacked = new Warrior("Toni", 50, 100);

            warrior.Attack(attacked);

            Assert.AreEqual(attacked.HP, 50);
            Assert.AreEqual(warrior.HP, 50);
        }
        [Test]
        public void AttackShouldLowerTheirHealth2()
        {
            warrior = new Warrior("Vlado", 50, 100);
            Warrior attacked = new Warrior("Toni", 50, 40);

            warrior.Attack(attacked);

            Assert.AreEqual(attacked.HP, 0);
            Assert.AreEqual(warrior.HP, 50);
        }
    }
}