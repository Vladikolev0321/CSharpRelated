using P05.BirthdayCelebrations.Contracts;
using System;
using System.Collections.Generic;
using System.Text;

namespace _05._Birthday_Celebrations.Models
{
    public class Pet : IBirthable
    {
        private string name;
        private string birthDate;

        public Pet(string name , string birthDate)
        {
            this.name = name;
            this.birthDate = birthDate;
        }

        public string GetBirth()
        {
            return this.birthDate;
        }
    }
}
