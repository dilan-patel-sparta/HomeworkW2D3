using System;
using System.Text;
using System.Collections.Generic;
using System.Collections;

namespace SolarSystem
{
    class Program
    {
        static void Main(string[] args)
        {
            Planet[] SolarSystem = { 
                new Planet("Mercury", 4879, 88, 57909227), 
                new Planet("Venus", 4879, 88, 108209475), 
                new Planet("Earth", 4879, 88, 149598262),
                new Planet("Mars", 4879, 88, 227943824),
                new Planet("Jupiter", 4879, 88, 778340821),
                new Planet("Saturn", 4879, 88, 1426666422),
                new GasGiant("Uranus", 4879, 88, 2870658186, "Hydrogen", 88, "Helium", 12),
                new GasGiant("Neptune", 4879, 88, 4498396441, "Hydrogen", 94, "Helium", 6)
            };
        }
    }

    class Planet
    {
        private string planetName;
        private int planetDiameter;
        private int lengthOfYear;
        private long distanceFromSun;

        public Planet()
        {
   
        }

        public Planet(string name, int diameter, int days, long distance)
        {
            string planetName = name;
            int planetDiameter = diameter;
            int lengthInYears = days;
            long distanceFromSun = distance;
        }

        public string PlanetName { get => planetName; set => planetName = value; }
        public int PlanetDiameter { get => planetDiameter; set => planetDiameter = value; }
        public int LengthOfYear { get => lengthOfYear; set => lengthOfYear = value; }
        public long DistanceFromSun { get => distanceFromSun; set => distanceFromSun = value; }

        ArrayList solarSystemList = new ArrayList();

        public void UsingCollections()
        {
            solarSystemList.Add(new Planet("Mercury", 4879, 88, 57909227));
            solarSystemList.Add(new Planet("Venus", 4879, 88, 108209475));
            solarSystemList.Add(new Planet("Earth", 4879, 88, 149598262));
            solarSystemList.Add(new Planet("Mars", 4879, 88, 227943824));
            solarSystemList.Add(new Planet("Jupiter", 4879, 88, 778340821));
            solarSystemList.Add(new Planet("Saturn", 4879, 88, 1426666422));
            solarSystemList.Add(new GasGiant("Uranus", 4879, 88, 2870658186, "Hydrogen", 88, "Helium", 12));
            solarSystemList.Add(new GasGiant("Neptune", 4879, 88, 4498396441, "Hydrogen", 94, "Helium", 6));

            Object planetJupiter = solarSystemList[4];

        }
    }

    class GasGiant : Planet
    {
        private string primaryGasElement;
        private int primaryGasPercentage;
        private string secondaryGasElement;
        private int secondaryGasPercentage;

        public GasGiant(string name, int diameter, int days, long distance, string gas1, int gas1per, string gas2, int gas2per)
        {
            string primaryGasElement = gas1;
            int primaryGasPercentage = gas1per;
            string secondaryGasElement = gas2;
            int secondaryGasPercentage= gas2per;
    }

        public string PrimaryGasElement { get => primaryGasElement; set => primaryGasElement = value; }
        public int PrimaryGasPercentage { get => primaryGasPercentage; set => primaryGasPercentage = value; }
        public string SecondaryGasElement { get => secondaryGasElement; set => secondaryGasElement = value; }
        public int SecondaryGasPercentage { get => secondaryGasPercentage; set => secondaryGasPercentage = value; }
    }
}
