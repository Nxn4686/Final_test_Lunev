namespace AnimalRegistry;

public abstract class PackAnimal : Animal
{
    public PackAnimal(string name, DateTime birthDate) : base(name, birthDate) { }
}

public class Horse : PackAnimal
{
    public Horse(string name, DateTime birthDate) : base(name, birthDate) { }
}

public class Camel : PackAnimal
{
    public Camel(string name, DateTime birthDate) : base(name, birthDate) { }
}

public class Donkey : PackAnimal
{
    public Donkey(string name, DateTime birthDate) : base(name, birthDate) { }
}