using P05.BirthdayCelebrations.Contracts;

namespace P05.BirthdayCelebrations
{
    public class Citizen :  IIdentifiable,IBirthable
    {
        private string name;
        private int age;
        private string id;
        private string birthdate;
        public Citizen(string name, int age, string id,string birthdate)
        {
            this.name = name;
            this.age = age;
            this.id = id;
            this.birthdate = birthdate;
        }

        public string GetBirth()
        {
            return this.birthdate;
        }

        //public string Name { get; }

        //public int Age { get; }

        //public string Id { get; }

        public string GetId()
        {
            return this.id;
        }
    }
}
