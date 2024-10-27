namespace AnimalRegistry;

public abstract class Pet : Animal
{
    public Pet(string name, DateTime birthDate) : base(name, birthDate) { }
}

public class Dog : Pet
{
    public Dog(string name, DateTime birthDate) : base(name, birthDate) { }
}

public class Cat : Pet
{
    public Cat(string name, DateTime birthDate) : base(name, birthDate) { }
}

public class Hamster : Pet
{
    public Hamster(string name, DateTime birthDate) : base(name, birthDate) { }
}
