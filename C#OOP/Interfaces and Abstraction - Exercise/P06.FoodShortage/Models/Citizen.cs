using P06.FoodShortage.Contracts;

namespace P06.FoodShortage
{
    public class Citizen :  IIdentifiable,IBirthable,IBuyer
    {
        //private string name;
        private int age;
        private string id;
        private string birthdate;
        private int food = 0;
        public Citizen(string name, int age, string id,string birthdate)
        {
            this.Name = name;
            this.age = age;
            this.id = id;
            this.birthdate = birthdate;
        }
        public string Name { get; }

        public int Food 
        { 
            get
            {
                return this.food;
            }
            private set
            {
                this.food = value;
            }
        }

        public void BuyFood()
        {
            this.Food += 10;
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
