using FightingArena;
using NUnit.Framework;
using System;

namespace Tests
{
    public class ArenaTests
    {
        private Arena arena;
        private Warrior w1;
        private Warrior attacker;
        private Warrior defender;
        [SetUp]
        public void Setup()
        {
            arena = new Arena();
            w1 = new Warrior("Vlado",5,50);

            attacker = new Warrior("Pesho", 10, 80);
            defender = new Warrior("Gosho", 5, 60);

        }

        [Test]
        public void TestIfConstructorWorksCorrectly()
        {
            Assert.IsNotNull(this.arena.Warriors);
        }
        [Test]
        public void EnrollShouldAddTheWarriorToTheArenaAndIncreaseCount()
        {
            arena.Enroll(w1);

            Assert.That(this.arena.Warriors, Has.Member(w1));
            Assert.AreEqual(1, arena.Warriors.Count);
        }
        [Test]
        public void EnrollingSameWarriorShouldThrowException()
        {
            arena.Enroll(w1);

            Assert.Throws<InvalidOperationException>(() =>
            {
                arena.Enroll(w1);
            });
        }
        [Test]
        public void EnrollingSameWarriorShouldThrowException2()
        {
            arena.Enroll(w1);
            Warrior w1Copy = new Warrior(w1.Name, w1.Damage, w1.HP);

            Assert.Throws<InvalidOperationException>(() =>
            {
                arena.Enroll(w1Copy);
            });
        }
        [Test]
        public void TestFightingWithMissingAttacker()
        {
            arena.Enroll(defender);

            Assert.Throws<InvalidOperationException>(() =>
            {
                arena.Fight(attacker.Name, defender.Name);
            });
        }
        [Test]
        public void TestFightingWithMissingDefender()
        {
            arena.Enroll(attacker);

            Assert.Throws<InvalidOperationException>(() =>
            {
                arena.Fight(attacker.Name, defender.Name);
            });
        }
        [Test]
        public void TestFightingBetweenTwoWarrioirs()
        {
            int expectedAHP = attacker.HP - defender.Damage;
            int expectedDHP = defender.HP - attacker.Damage;


            arena.Enroll(attacker);
            arena.Enroll(defender);

            arena.Fight(attacker.Name, defender.Name);


            Assert.AreEqual(expectedAHP, attacker.HP);
            Assert.AreEqual(defender.HP, defender.HP);


        }

    }
}
