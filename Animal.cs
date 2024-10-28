using System;
using System.Collections.Generic;

namespace AnimalRegistry;

public class Animal
{
    public int Id { get; set; }
    public string Name { get; set; }
    public DateTime BirthDate { get; set; }
    public List<string> Commands { get; set; }

    public string Type { get; set; } // Тип животного (Dog, Cat, Hamster, Horse, Camel, Donkey)

    public Animal(string name, DateTime birthDate, string type)
    {
        Name = name;
        BirthDate = birthDate;
        Type = type;
    }

    public virtual void ShowCommands()
    {
        Console.WriteLine($"Commands for {Name}: {string.Join(", ", Commands)}");
    }

    public void LearnCommand(string command)
    {
        Commands.Add(command);
    }
}

