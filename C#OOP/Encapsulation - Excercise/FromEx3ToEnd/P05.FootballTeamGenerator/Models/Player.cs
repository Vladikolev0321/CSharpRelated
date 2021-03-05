using P05.FootballTeamGenerator.Common;
using System;
using System.Collections.Generic;
using System.Text;

namespace P05.FootballTeamGenerator.Models
{
    public class Player
    {
        private string name;
        

        public Player(string name , Stats stats)
        {
            this.Name = name;
            this.Stats = stats;
        }
        public string Name
        {
            get
            {
                return this.name;
            }
            private set
            {
                if (string.IsNullOrWhiteSpace(value))
                {
                    throw new ArgumentException(GlobalConstants.EmptyNameExceptionMessage);
                }
                this.name = value;
            }
        }
        public Stats Stats { get; }

        public double OverallSkill
        {
            get
            {
                return this.Stats.AverageStat();
            }
        }
    }
}
