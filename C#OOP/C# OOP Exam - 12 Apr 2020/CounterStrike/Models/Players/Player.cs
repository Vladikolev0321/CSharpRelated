using CounterStrike.Models.Guns.Contracts;
using CounterStrike.Models.Players.Contracts;
using CounterStrike.Utilities.Messages;
using System;
using System.Collections.Generic;
using System.Text;

namespace CounterStrike.Models.Players
{
    public abstract class Player : IPlayer
    {
        private string name;
        private int health;
        private int armour;
        private IGun gun;

        public Player(string username,int health, int armor,IGun gun)
        {
            this.Username = username;
            this.Health = health;
            this.Armor = armor;
            this.Gun = gun;
        }
        public string Username
        {
            get
            {
                return this.name;
            }
            private set
            {
                if (string.IsNullOrWhiteSpace(value))
                {
                    throw new ArgumentException(ExceptionMessages.InvalidPlayerName);
                }
                this.name = value;
            }
        }

        public int Health
        {
            get
            {
                return this.health;
            }
            private set
            {
                if(value < 0)
                {
                    throw new ArgumentException(ExceptionMessages.InvalidPlayerHealth);
                }
                this.health = value;
            }
        }

        public int Armor
        {
            get
            {
                return this.armour;
            }
            private set
            {
                if(value < 0)
                {
                    throw new ArgumentException(ExceptionMessages.InvalidPlayerArmor);
                }
                this.armour = value;
            }
        }

        public IGun Gun
        {
            get
            {
                return this.gun;
            }
            private set
            {
                if (value == null)
                {
                    throw new ArgumentException(ExceptionMessages.InvalidGun);
                }
                this.gun = value;
            }
        }

        public bool IsAlive => this.Health > 0;
        ///Not sure for IsAlive
        public void TakeDamage(int points)
        {
           if(this.Armor - points <= 0)
           {
                points -= this.Armor;
                this.Armor = 0;
                if(this.Health - points <= 0)
                {
                    this.Health = 0;
                }
                else
                {
                    this.Health -= points;
                }
           }
           else
           {
                this.Armor -= points;
           }

        }
    }
}
