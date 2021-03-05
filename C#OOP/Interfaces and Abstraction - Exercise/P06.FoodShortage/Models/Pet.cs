namespace P06.FoodShortage
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
