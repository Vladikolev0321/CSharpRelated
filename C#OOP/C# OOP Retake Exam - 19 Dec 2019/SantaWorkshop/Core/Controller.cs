using SantaWorkshop.Core.Contracts;
using SantaWorkshop.Models.Dwarfs;
using SantaWorkshop.Models.Dwarfs.Contracts;
using SantaWorkshop.Models.Instruments;
using SantaWorkshop.Models.Instruments.Contracts;
using SantaWorkshop.Models.Presents;
using SantaWorkshop.Models.Presents.Contracts;
using SantaWorkshop.Models.Workshops;
using SantaWorkshop.Repositories;
using SantaWorkshop.Repositories.Contracts;
using SantaWorkshop.Utilities.Messages;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SantaWorkshop.Core
{
    public class Controller : IController
    {
        private DwarfRepository dwarfs;
        private PresentRepository presents;

        public Controller()
        {
            this.dwarfs = new DwarfRepository();
            this.presents = new PresentRepository();
        }

        public string AddDwarf(string dwarfType, string dwarfName)
        {
            //"HappyDwarf" and "SleepyDwarf".
            IDwarf dwarf = null;
            if(dwarfType == "HappyDwarf")
            {
                dwarf = new HappyDwarf(dwarfName);
            }
            else if(dwarfType == "SleepyDwarf")
            {
                dwarf = new SleepyDwarf(dwarfName);
            }
            else
            {
                throw new InvalidOperationException(ExceptionMessages.InvalidDwarfType);
            }
            dwarfs.Add(dwarf);
            return string.Format(OutputMessages.DwarfAdded, dwarfType, dwarfName);
        }

        public string AddInstrumentToDwarf(string dwarfName, int power)
        {
            if(this.dwarfs.FindByName(dwarfName) == null)
            {
                throw new InvalidOperationException(ExceptionMessages.InexistentDwarf);
            }

            IDwarf dwarf = dwarfs.FindByName(dwarfName);
            IInstrument instrument = new Instrument(power);

            dwarf.AddInstrument(instrument);
            return string.Format(OutputMessages.InstrumentAdded,power,dwarfName);
        }

        public string AddPresent(string presentName, int energyRequired)
        {
            IPresent present = new Present(presentName, energyRequired);
            presents.Add(present);

            return string.Format(OutputMessages.PresentAdded,presentName);
        }

        public string CraftPresent(string presentName)
        {
            IPresent present = presents.FindByName(presentName);
            ICollection<IDwarf> dwarves = dwarfs
                .Models
                .Where(d => d.Energy >= 50)
                .OrderByDescending(d => d.Energy)
                .ToList();

            if(dwarves.Count == 0)
            {
                throw new InvalidOperationException(ExceptionMessages.DwarfsNotReady);
            }

            Workshop workshop = new Workshop();

            while(dwarves.Any())
            {
                IDwarf currDwarf = dwarves.First();
                workshop.Craft(present, currDwarf);
                if (!currDwarf.Instruments.Any())
                {
                    dwarves.Remove(currDwarf);
                }
                if(currDwarf.Energy == 0)
                {
                    dwarves.Remove(currDwarf);
                    this.dwarfs.Remove(currDwarf);
                }
                if (present.IsDone())
                {
                    return string.Format(OutputMessages.PresentIsDone,presentName);
                }

            }
            ///////PresentISDone
            return string.Format(OutputMessages.PresentIsNotDone, presentName);

        }

        public string Report()
        {
            StringBuilder sb = new StringBuilder();
            int countCraftedPresents = this.presents
                .Models
                .Count(p => p.IsDone());



            sb
                .AppendLine($"{countCraftedPresents} presents are done!")
                .AppendLine($"Dwarfs info:");

            foreach (IDwarf dwarf in this.dwarfs.Models)
            {
                int countNotBrokenInstruments = dwarf
                    .Instruments
                    .Count(i => !i.IsBroken());
                sb
                    .AppendLine($"Name: {dwarf.Name}")
                    .AppendLine($"Energy: {dwarf.Energy}")
                    .AppendLine($"Instruments: {countNotBrokenInstruments} not broken left");
            }

            return sb.ToString().TrimEnd();
        }
    }
}
