using P05.FootballTeamGenerator.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace P05.FootballTeamGenerator.Models
{
    public class Team
    {
        private string name;
        private List<Player> players;

        private Team()
        {
            this.players = new List<Player>();
        }
        public Team(string name)
            :this()
        {
            this.Name = name;
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
        public int Rating
        {
            get
            {
                if(this.players.Count == 0)
                {
                    return 0;
                }

                return (int)(Math.Round((this.players.Sum(p => p.OverallSkill) /
                    this.players.Count)));
            }

        }
        public void AddPlayer(Player player)
        {
            this.players.Add(player);
        }
        public void RemovePlayer(string name)
        {
            Player playerTORemove = this.players
                .FirstOrDefault(p => p.Name == name);

            if(playerTORemove == null)
            {
                string exceptionMessage = string
                    .Format(GlobalConstants.RemovingMissingPlayerExceptionMessage
                    , name, this.Name);
                throw new InvalidOperationException(string.Format(exceptionMessage));
            }

            this.players.Remove(playerTORemove);
        }
        public override string ToString()
        {
            return $"{this.Name} - {this.Rating}";
        }

    }
}
