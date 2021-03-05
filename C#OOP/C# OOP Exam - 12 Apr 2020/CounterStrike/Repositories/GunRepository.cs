﻿using CounterStrike.Models.Guns.Contracts;
using CounterStrike.Repositories.Contracts;
using CounterStrike.Utilities.Messages;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CounterStrike.Repositories
{
    public class GunRepository : IRepository<IGun>
    {
        private readonly ICollection<IGun> models;

        public GunRepository()
        {
            this.models = new List<IGun>();
        }
        public IReadOnlyCollection<IGun> Models
            => (IReadOnlyCollection<IGun>)this.models;

        public void Add(IGun model)
        {
            if(model == null)
            {
                throw new ArgumentException(ExceptionMessages.InvalidGunRepository);
            }
            this.models.Add(model);
        }

        public IGun FindByName(string name)
        {
            ///Not sure if it returns Null
            return this.models.FirstOrDefault(m => m.Name == name);
        }

        public bool Remove(IGun model)
        {
            return this.models.Remove(model);
        }
    }
}
