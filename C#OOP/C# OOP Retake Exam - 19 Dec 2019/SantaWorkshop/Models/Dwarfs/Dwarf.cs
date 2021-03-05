using SantaWorkshop.Models.Dwarfs.Contracts;
using SantaWorkshop.Models.Instruments.Contracts;
using SantaWorkshop.Utilities.Messages;
using System;
using System.Collections.Generic;
using System.Text;

namespace SantaWorkshop.Models.Dwarfs
{
    public abstract class Dwarf : IDwarf
    {
        private string name;
        private int energy;

        private Dwarf()
        {
            this.Instruments = new List<IInstrument>();
        }
        public Dwarf(string name,int energy)     
            :this()
        {
            this.Name = name;
            this.Energy = energy;
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
                    throw new ArgumentException(ExceptionMessages.InvalidDwarfName);
                }
                this.name = value;
            }
        }

        public int Energy
        {
            get
            {
                return this.energy;
            }
            protected set
            {
                if(value < 0)
                {
                    this.energy = 0;
                }
                else
                {
                    this.energy = value;
                }
            }
        }

        public ICollection<IInstrument> Instruments { get; }

        public void AddInstrument(IInstrument instrument)
        {
            this.Instruments.Add(instrument);
        }

        public virtual void Work()
        {
            this.Energy -= 10;
        }
    }
}
