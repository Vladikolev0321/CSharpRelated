namespace P05.BirthdayCelebrations
{
    class Robot :  IIdentifiable
    {
        private string model;
        private string id;
        public Robot(string model, string id)
        {
            this.model = model;
            this.id = id;
        }
        //public string Model { get; }

        //public string Id { get; }

        public string GetId()
        {
            return this.id;
        }
    }
}
