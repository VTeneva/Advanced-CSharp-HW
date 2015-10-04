using System;
using System.Collections.Generic;
using System.Linq;

class NightLife
{
    static void Main()
    {
        Dictionary<string, SortedDictionary<string, SortedSet<string>>> events = new Dictionary<string, SortedDictionary<string, SortedSet<string>>>();

        string input = Console.ReadLine();

        while (input != "END")
        {
            string[] newEvent = input.Split(";".ToCharArray(), StringSplitOptions.RemoveEmptyEntries).ToArray(); // Input string into array: Position 0 - City, Position 1 - venue, Position 2 - performer
            string city = newEvent[0];
            string venue = newEvent[1];
            string performer = newEvent[2];

            if (!events.ContainsKey(city)) // Adds new city (key) to the dictionary.
            {
                events.Add(
                    city,
                    new SortedDictionary<string, SortedSet<string>>()
                    );
            }
            if (!events[city].ContainsKey(venue)) // Add new venue.
            {
                events[city].Add(
                        venue,
                        new SortedSet<string>()
                );
            }
            if (!events[city][venue].Contains(performer)) // Add new venue.
            {
                events[city][venue].Add(performer);
            }

            input = Console.ReadLine(); // Reads next line.
        }

        //Print results
        foreach (var cities in events)
        {
            Console.WriteLine(cities.Key);
            foreach (var venues in cities.Value)
            {
                Console.WriteLine("->{0}: {1}", venues.Key, string.Join(", ", venues.Value));
            }
        }
    }
}
