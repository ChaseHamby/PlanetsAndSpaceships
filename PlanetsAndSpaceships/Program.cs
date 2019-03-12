using System;
using System.Collections.Generic;

namespace PlanetsAndSpaceships
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> planetList = new List<string>() { "Mercury", "Mars" };

            planetList.Add("Jupiter");

            planetList.Add("Saturn");

            List<string> otherPlanets = new List<string>() { "Uranus", "Neptune" };

            planetList.AddRange(otherPlanets);

            planetList.Insert(2, "Earth");

            planetList.Insert(1, "Venus");

            planetList.Add("Pluto");

            List<string> rockyPlanets = planetList.GetRange(0, 4);

            planetList.Remove("Pluto");

            // Spacecraft Probes

            var mercurySpacecraft = new List<string>() { "Mariner 1", "Venera 1", "Ulysesses" };

            var venusSpacecraft = new List<string>() { "Mariner 8", "Vega 2", "Zond 1" };

            var marsSpacecraft = new List<string>() { "Maven" };

            var jupiterSpacecraft = new List<string>() { "Pioneer 2", "Juno", "Ulysesses" };

            var saturnSpacecraft = new List<string>() { "Voyager 2", "Cassini" };

            var uranusSpacecraft = new List<string>() { "Voyager 2" };

            var neptuneSpacecraft = new List<string>() { "Voyager 2" };

            var probesByPlanet = new Dictionary<string, List<string>>
            {
                { "Mercury", mercurySpacecraft },
                { "Venus", venusSpacecraft },
                { "Mars", marsSpacecraft },
                { "Jupiter", jupiterSpacecraft},
                { "Saturn", saturnSpacecraft },
                { "Uranus", uranusSpacecraft },
                { "Neptune", neptuneSpacecraft },
            };

            foreach (var (planet, probes) in probesByPlanet)
            {
                Console.WriteLine($"{planet}: ");
                foreach (var probe in probes)
                {
                    Console.WriteLine(probe);
                }
            }
            Console.ReadLine();
        }
    }
}
