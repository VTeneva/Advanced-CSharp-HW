using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

class SrabskoUnleashed
{
    static void Main()
    {
        Dictionary<string, Dictionary<string, List<int>>> citiesVenues = new Dictionary<string, Dictionary<string, List<int>>>();

        List<string> inputLine = Console.ReadLine().Split(' ').ToList();

        while (inputLine[0] != "End")
        {
            if (inputLine.Count >= 4)
            {
                StringBuilder city = new StringBuilder();
                StringBuilder singer = new StringBuilder();

                int i = 0;

                while (inputLine[i][0] != '@')
                {
                    singer.Append(" ");
                    singer.Append(inputLine[i]);
                    i++;
                }

                while (!((int)inputLine[i][0] >= 48 && (int)inputLine[i][0] <= 57))
                { 
                    city.Append(" ");
                    if (inputLine[i].IndexOf('@') > -1)
                    {
                        city.Append(inputLine[i].Remove(inputLine[i].IndexOf('@'), 1));
                    }
                    else
                    {
                        city.Append(inputLine[i]);
                    }
                    i++;
                }

                if (!citiesVenues.ContainsKey(city.ToString().Trim()))
                {
                    citiesVenues.Add(
                        city.ToString().Trim(),
                        new Dictionary<string, List<int>>()
                        );
                }

                if (!citiesVenues[city.ToString().Trim()].ContainsKey(singer.ToString().Trim()))
                {
                    citiesVenues[city.ToString().Trim()].Add(
                         singer.ToString().Trim(),
                         new List<int>()
                         );
                }
                
                {
                    citiesVenues[city.ToString().Trim()][singer.ToString().Trim()].
                        Add(int.Parse(inputLine[inputLine.Count - 2])*
                            int.Parse(inputLine[inputLine.Count - 1]));
                }
                
            }

            inputLine = Console.ReadLine().Split(' ').ToList();
        }

        foreach (var city in citiesVenues)
        {
            Console.WriteLine(city.Key);

            foreach (var singer in city.Value.OrderByDescending(singer => singer.Value.Sum()))
            {
                Console.WriteLine("#  {0} -> {1}", singer.Key, singer.Value.Sum());

            }
        }
    }
}

