using System;
using System.Collections.Generic;
using System.Text;

namespace _280121
{
    class Car
    {
        public int NumberOfDoors { get; set; }
        public string Brand { get; set; }
        public string Make { get; set; }
        public string TypeOfFuel { get; set; }
        public int YearOfManuFacture { get; set; }
        public string LicensNumber { get; set; }

        int CurrentSpeed;

        public void IncreaseCurrentSpeed(int increase, int duringTime)
        {
            CurrentSpeed += increase;
            VeryComplexInternalMethodToFeedFuelToTheEngine();
        }

        void VeryComplexInternalMethodToFeedFuelToTheEngine()
        {
            //Komplexa saker
        }
    }
}
