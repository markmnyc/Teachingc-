using System;

namespace ObjectOrientatedLanguage.Models
{
    public class Motorvehicle : IEquatable<Car>
    {
        public string Color { get; set; }
        public string Brand { get; set; }

        public bool Equals(Car car)
        {
            return this.Color == car.Color && 
                   this.Brand == car.Brand;
        }
    }
}
