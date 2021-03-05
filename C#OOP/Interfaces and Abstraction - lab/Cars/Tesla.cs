using System;
using System.Collections.Generic;
using System.Text;

namespace Cars
{
    public class Tesla : Car,IElectricCar
    {
        public Tesla(string model , string color)
            :base(model,color)
        {
            
        }
        public Battery Battery { get; set; }

        
        public override string Start()
        {
            return "Tesla does not make any noise.";
        }

       
    }
}
