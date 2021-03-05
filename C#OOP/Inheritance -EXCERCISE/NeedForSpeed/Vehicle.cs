namespace P04.NeedForSpeed
{
    public class Vehicle
    {
        private const double defaultFuelConsumption = 1.25;

        private double fuelConsumption;

        public Vehicle(int horsePower, double fuel)
        {
            this.HorsePower = horsePower;
            this.Fuel = fuel;
        }

        //public double DefaultFuelConsumption
        //{
        //    get
        //    {
        //        return this.defaultFuelConsumption;
        //    }
        //    set 
        //    {
        //        this.defaultFuelConsumption = value;
        //    }
        //}
        public virtual double FuelConsumption => defaultFuelConsumption;
        //{
        //    get
        //    {
        //        return this.FuelConsumption;
        //    }
        //    set
        //    {
        //        this.FuelConsumption = defaultFuelConsumption;
        //    }
        //}

        public int HorsePower { get; set; }
        public double Fuel { get; set; }

        public virtual void Drive(double kilometers)
        {
            double fuelAfterDrive = this.Fuel - kilometers * this.FuelConsumption;
            if(fuelAfterDrive >= 0)
            {
            this.Fuel -= kilometers * this.FuelConsumption;
            }

        }



    }
}
