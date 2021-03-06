using System;
using System.Collections.Generic;
using System.Text;

namespace Encapsulation
{
    public class Team
    {
        private List<Person> firstTeam;
        private List<Person> reserveTeam;

        public Team(string name)
        {
            this.Name = name;

            this.firstTeam = new List<Person>();
            this.reserveTeam = new List<Person>();
        }
        public string Name { get; }
        public IReadOnlyList<Person> FirstTeam
        {
            get 
            { 
                return this.firstTeam; 
            }
        }
        public IReadOnlyList<Person> ReserveTeam
        {
            get
            {
                return this.reserveTeam;
            }
        }

        public void AddPlayer(Person player)
        {
            if(player.Age < 40)
            {
                this.firstTeam.Add(player);
            }
            else
            {
                this.reserveTeam.Add(player);
            }
        }


    }
}
