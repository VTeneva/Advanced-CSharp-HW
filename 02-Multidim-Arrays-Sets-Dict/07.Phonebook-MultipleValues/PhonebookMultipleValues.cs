using System;
using System.Collections.Generic;
using System.Linq;

class Phonebook
{
    static void Main()
    {
        Dictionary<string, List<string>> phonebook = new Dictionary<string, List<string>>();

        // Fil the contact list.
        Console.WriteLine("Enter contacts. Please use '-' as separator!");
        string line = Console.ReadLine();
        string[] contact = line.Split('-').ToArray();
        do
        {
            if (!phonebook.ContainsKey(contact[0])) // Creates new contact if this not exist in the phonebook.
            {
                phonebook.Add(
                contact[0],
                new List<string>()
                );
            }
                phonebook[contact[0]].Add(contact[1]); //Adds the number to the contact.

            line = Console.ReadLine();
            contact = line.Split('-').ToArray();
        } while (line != "search");


        string searchLine = Console.ReadLine();
        while (searchLine != "")
        {
            if (phonebook.ContainsKey(searchLine) == true)
            {
                Console.WriteLine("{0} -> {1}", searchLine, string.Join(", ", phonebook[searchLine]));
            }
            else
            {
                Console.WriteLine("Contact {0} does not exist.", searchLine);
            }
            searchLine = Console.ReadLine();
        }
    }
}

