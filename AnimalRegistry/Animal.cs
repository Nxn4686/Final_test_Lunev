using System;
using System.Collections.Generic;

namespace AnimalRegistry;

public abstract class Animal
{
    public string Name { get; set; }
    public DateTime BirthDate { get; set; }
    public List<string> Commands { get; set; } = new List<string>();

    public Animal(string name, DateTime birthDate)
    {
        Name = name;
        BirthDate = birthDate;
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

