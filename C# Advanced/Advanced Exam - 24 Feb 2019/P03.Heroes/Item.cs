using System;
using System.Collections.Generic;
using System.Text;

namespace Heroes
{
    public class Item
    {
        public Item(int strenght,int ability,int intelligence)
        {
            this.Strength = strenght;
            this.Ability = ability;
            this.Intelligence = intelligence;
        }
        public int Strength { get; set; }
        public int Ability { get; set; }
        public int Intelligence { get; set; }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb
                .AppendLine("Item:")
                .AppendLine($"  * Strength: {this.Strength}")
                .AppendLine($"  * Ability: {this.Ability}")
                .AppendLine($"  * Intelligence: {this.Intelligence}");

            return sb.ToString().TrimEnd();

        }

    }
}
