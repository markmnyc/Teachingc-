

namespace ObjectOrientatedLanguage.Models
{
    public class Car : Vehicle/*IEquatable<Motorvehicle>*/
    {
        public string Brand { get; set; }
        public string Color { get; set; }

        public Car()
        {
            Color = "Blue";
            Brand = "BMW";
            void StartCar()
            {
                bool isCarStarted = true;
            }
        }

        public bool isCarStarted()
        {
            return true;
        }

        //public bool Equals(Motorvehicle motorvehicle)
        //{
        //    return this.Color == motorvehicle.Color &&
        //           motorvehicle.Brand == motorvehicle.Brand;
        //}
    }
}
