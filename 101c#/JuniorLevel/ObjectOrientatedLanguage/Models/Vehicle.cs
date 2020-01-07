
namespace ObjectOrientatedLanguage.Models
{
    public class Vehicle
    {
        public int NumberOfDoors { get;}
        public int NumberOfDoorHandles { get; set; }
        public int NumberOfTyres { get; set; }
        private EngineType EngineType { get; set; }

        public Vehicle()
        {
            NumberOfDoors = 4;
            //NumberOfDoorHandles = 8;
        }
    }
}
