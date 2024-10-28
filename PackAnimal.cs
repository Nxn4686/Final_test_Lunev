namespace AnimalRegistry;

public abstract class PackAnimal : Animal
{
    public PackAnimal(string name, DateTime birthDate, string type) : base(name, birthDate, type) { }
}

public class Horse : PackAnimal
{
    public Horse(string name, DateTime birthDate) : base(name, birthDate, "Horse") { }
}

public class Camel : PackAnimal
{
    public Camel(string name, DateTime birthDate) : base(name, birthDate, "Camel") { }
}

public class Donkey : PackAnimal
{
    public Donkey(string name, DateTime birthDate) : base(name, birthDate, "Donkey") { }
}