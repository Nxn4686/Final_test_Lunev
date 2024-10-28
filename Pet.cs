namespace AnimalRegistry;

public abstract class Pet : Animal
{
    public Pet(string name, DateTime birthDate, string type) : base(name, birthDate, type) { }
}

public class Dog : Pet
{
    public Dog(string name, DateTime birthDate) : base(name, birthDate, "Dog") { }
}

public class Cat : Pet
{
    public Cat(string name, DateTime birthDate) : base(name, birthDate, "Cat") { }
}

public class Hamster : Pet
{
    public Hamster(string name, DateTime birthDate) : base(name, birthDate, "Hamster") { }
}
