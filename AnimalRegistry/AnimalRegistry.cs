namespace AnimalRegistry
{
    public class AnimalRegistry
    {
        private List<Animal> animals = new List<Animal>();

        public void AddAnimal(Animal animal)
        {
            animals.Add(animal);
            AnimalCounter.AddAnimal();
            Console.WriteLine($"{animal.Name} has been added to the registry.");
        }

        public Animal GetAnimalByName(string name)
        {
            foreach(Animal animal in animals)
            {
                if (animal.Name == name)
                    return animal;
            }

            return null;
        }

        public void ShowAnimalCommands(string name)
        {
            var animal = GetAnimalByName(name);
            if (animal != null)
            {
                animal.ShowCommands();
            }
            else
            {
                Console.WriteLine("Animal not found.");
            }
        }

        public void TeachCommand(string name, string command)
        {
            var animal = GetAnimalByName(name);
            if (animal != null)
            {
                animal.LearnCommand(command);
                Console.WriteLine($"{name} has learned the command: {command}");
            }
            else
            {
                Console.WriteLine("Animal not found.");
            }
        }

        public void ShowAnimalsByBirthDate()
        {
            foreach (var animal in animals)
            {
                Console.WriteLine($"{animal.Name} was born on {animal.BirthDate.ToShortDateString()}");
            }
        }

        public int GetTotalAnimalsCount()
        {
            return AnimalCounter.GetCount();
        }
    }

}
