using AquaShop.Core.Contracts;
using AquaShop.Models.Aquariums;
using AquaShop.Models.Aquariums.Contracts;
using AquaShop.Models.Decorations;
using AquaShop.Models.Decorations.Contracts;
using AquaShop.Models.Fish;
using AquaShop.Models.Fish.Contracts;
using AquaShop.Repositories;
using AquaShop.Utilities.Messages;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Headers;
using System.Text;

namespace AquaShop.Core
{
    public class Controller : IController
    {
        //IRepository<IDecoration>
        private readonly DecorationRepository decorations;
        private readonly ICollection<IAquarium> aquariums;

        public Controller()
        {
            decorations = new DecorationRepository();
            aquariums = new List<IAquarium>();
        }

        public string AddAquarium(string aquariumType, string aquariumName)
        {
            IAquarium aquarium;
            if(aquariumType == "FreshwaterAquarium")
            {
                aquarium = new FreshwaterAquarium(aquariumName);
            }
            else if(aquariumType == "SaltwaterAquarium")
            {
                aquarium = new SaltWaterAquarium(aquariumName);
            }
            else
            {
                throw new InvalidOperationException(ExceptionMessages.InvalidAquariumType);
            }
            this.aquariums.Add(aquarium);

            return string.Format(OutputMessages.SuccessfullyAdded,aquariumType);
            
        }

        public string AddDecoration(string decorationType)
        {
            IDecoration decoration;
            if (decorationType == "Ornament")
            {
                decoration = new Ornament();
            }
            else if (decorationType == "Plant")
            {
                decoration = new Plant();
            }
            else
            {
                throw new InvalidOperationException(ExceptionMessages.InvalidDecorationType);
            }

            this.decorations.Add(decoration);

            return string.Format(OutputMessages.SuccessfullyAdded, decorationType);

        }

        public string AddFish(string aquariumName, string fishType,
            string fishName, string fishSpecies, decimal price)
        {
            IFish fish;
            if(fishType == "FreshwaterFish")
            {
                fish = new FreshwaterFish(fishName, fishSpecies, price);
            }
            else if(fishType == "SaltwaterFish")
            {
                fish = new SaltwaterFish(fishName, fishSpecies, price);
            }
            else
            {
                throw new InvalidOperationException(ExceptionMessages.InvalidFishType);
            }
            var aquarium = this.aquariums.FirstOrDefault(a => a.Name == aquariumName);

            if(fishType == "SaltwaterFish" && aquarium.GetType().Name != nameof(SaltWaterAquarium))
            {//can add
                return OutputMessages.UnsuitableWater;
            }
            if (fishType == "FreshwaterFish" && aquarium.GetType().Name != nameof(FreshwaterAquarium))
            {//can add
                return OutputMessages.UnsuitableWater;
            }

            aquarium.AddFish(fish);
            return string.Format(OutputMessages.EntityAddedToAquarium, fishType, aquariumName);

        }

        public string CalculateValue(string aquariumName)
        {
            IAquarium aquarium = this.aquariums.FirstOrDefault(a => a.Name == aquariumName);

            decimal result = aquarium.Fish.Sum(f => f.Price)
                + aquarium.Decorations.Sum(d => d.Price);

            return string.Format(OutputMessages.AquariumValue, aquariumName, result);
        }

        public string FeedFish(string aquariumName)
        {
            IAquarium aquarium = this.aquariums.First(a => a.Name == aquariumName);
            aquarium.Feed();

            return string.Format(OutputMessages.FishFed,aquarium.Fish.Count);
        }

        public string InsertDecoration(string aquariumName, string decorationType)
        {
            if(this.decorations.FindByType(decorationType) == null)
            {
                throw new InvalidOperationException(string.Format(ExceptionMessages.InexistentDecoration, decorationType));
            }

            IDecoration decoration = this.decorations.FindByType(decorationType);
            IAquarium aquarium = this.aquariums.FirstOrDefault(a => a.Name == aquariumName);
            aquarium.AddDecoration(decoration);
            decorations.Remove(decoration);

            return string.Format(OutputMessages.EntityAddedToAquarium,decorationType,aquariumName);
        }

        public string Report()
        {
            StringBuilder sb = new StringBuilder();
            foreach (IAquarium aquarium in this.aquariums)
            {
                sb.AppendLine(aquarium.GetInfo());
            }

            return sb.ToString().TrimEnd();
        }
    }
}
