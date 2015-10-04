using System;
using System.Collections.Generic;
using System.Linq;

class Phonebook
{
    static void Main()
    {
        Dictionary<string, string>  phonebook = new Dictionary<string, string>();

        // Fil the contact list.
        Console.WriteLine("Enter contacts. Please use '-' as separator!");
        string line = Console.ReadLine();
        string[] contact = line.Split('-').ToArray();
        do
        {
            phonebook.Add(
                contact[0],
                contact[1]
                );

            line = Console.ReadLine();
            contact = line.Split('-').ToArray();
        } while (line != "search");


        string searchLine = Console.ReadLine();
        while (searchLine != "")
        {
            if (phonebook.ContainsKey(searchLine) == true)
            {
                Console.WriteLine("{0} -> {1}", searchLine, phonebook[searchLine]);
            }
            else
            {
                Console.WriteLine("Contact {0} does not exist.", searchLine);
            }
            searchLine = Console.ReadLine();
        }
    }
}

