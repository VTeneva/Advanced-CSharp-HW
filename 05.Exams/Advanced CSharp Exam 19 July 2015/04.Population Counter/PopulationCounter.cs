using System;
using System.Collections.Generic;
using System.Linq;

class PopulationCounter
{
    static void Main()
    {
        Dictionary<string, Dictionary<string, int>> countries = new Dictionary<string, Dictionary<string, int>>();
        string line = Console.ReadLine();

        while (line != "report")
        {
            string[] countryCityPair = line.Split('|').ToArray();

            if (!countries.ContainsKey(countryCityPair[1]))
            {
                countries.Add(
                    countryCityPair[1],
                    new Dictionary<string, int>());
            }

            countries[countryCityPair[1]].Add(
                countryCityPair[0],
                int.Parse(countryCityPair[2]));

            line = Console.ReadLine();
        }

        Dictionary<string, ulong> countryPopulation = new Dictionary<string, ulong>();


        foreach (var country in countries)
        {
            ulong countryPop = 0;
            foreach (var city in country.Value)
            {
                countryPop += (ulong)city.Value;
            }

            countryPopulation.Add(country.Key, (ulong)countryPop);
        }

        foreach (var country in countryPopulation.OrderByDescending(x => x.Value))
        {
            Console.WriteLine("{0} (total population: {1})", country.Key, country.Value);

            foreach (var city in countries[country.Key].OrderByDescending(city => city.Value))
            {
                Console.WriteLine("=>{0}: {1}", city.Key, city.Value);
            }
                
        }
    }
}
