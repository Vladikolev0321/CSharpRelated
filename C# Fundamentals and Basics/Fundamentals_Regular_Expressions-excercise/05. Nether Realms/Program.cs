using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;

namespace _05._Nether_Realms
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> names = Console.ReadLine()
                 .Split(new char[] { ' ', ',' }, StringSplitOptions.RemoveEmptyEntries).OrderBy(d => d)
                 .ToList();
            Dictionary<string, int> health = new Dictionary<string, int>();
            Dictionary<string, decimal> damage = new Dictionary<string, decimal>();

            foreach (string name in names)
            {
                if (!health.ContainsKey(name) && !damage.ContainsKey(name))
                {
                    health[name] = GetHealth(name);
                    damage[name] = GetDamage(name);
                }
            }


            foreach (string name in names.OrderBy(n => n))
            {
                Console.WriteLine($"{name} - {health[name]} health, {damage[name]:F2} damage");
            }
        }
        static decimal GetDamage(string name)
        {
            string damagePattern = @"([-+])?\d+(\.\d+)?";
            //Problem with mine pattern;
           // string damagePattern = @"[\-\+]?[\d]+(?:[\.]*[\d]+|[\d]*)";
            var matches = Regex.Matches(name, damagePattern);

            decimal damage = 0;
            foreach (Match  match in matches)
            {
                damage += decimal.Parse(match.Value);
            }

            foreach (char c in name)
            {
                if(c == '*')
                {
                    damage *= 2;
                }
                else if(c == '/')
                {
                    damage /= 2;
                }
            }
            return damage;


        }
        static int GetHealth(string name)
        {
            string healthPatttern = @"[^0-9\+\-*/\.]";
           // string healthPatttern = @"[^0-9\+\-\*\/\.]+";
            var matches = Regex.Matches(name, healthPatttern);
            int health = 0;
            foreach (Match match in matches)
            {
                char currCh = char.Parse(match.Value);
                health += (int)(currCh);
            }
            return health;
        }
    }
}
