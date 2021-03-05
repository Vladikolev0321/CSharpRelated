using CounterStrike.Models.Maps.Contracts;
using CounterStrike.Models.Players.Contracts;
using CounterStrike.Utilities.Messages;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CounterStrike.Models.Maps
{
    public class Map : IMap
    {
        public string Start(ICollection<IPlayer> players)
        {
            var terrorists = players.Where(p => p.GetType().Name == "Terrorist");
            var counterTerrorists = players.Where(p => p.GetType().Name == "CounterTerrorist");

            ////////
            while(terrorists.Any(p => p.IsAlive) && counterTerrorists.Any(c => c.IsAlive))
            {
                foreach (IPlayer terrorist in terrorists.Where(t => t.IsAlive))
                {
                    int damage = terrorist.Gun.Fire();
                    foreach (IPlayer counterTerrorist in counterTerrorists.Where(c => c.IsAlive))
                    {
                        counterTerrorist.TakeDamage(damage);
                    }
                }

                foreach (IPlayer counterTerrorist in counterTerrorists.Where(t => t.IsAlive))
                {
                    int damage = counterTerrorist.Gun.Fire();
                    foreach (IPlayer terrorist in terrorists.Where(c => c.IsAlive))
                    {
                        terrorist.TakeDamage(damage);
                    }
                }
            }
            if(terrorists.Any(t => t.IsAlive))
            {
                return "Terrorist wins!";
            }
            else 
            {
                return "Counter Terrorist wins!";
            }


        }
    }
}
