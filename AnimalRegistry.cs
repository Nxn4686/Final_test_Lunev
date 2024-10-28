namespace AnimalRegistry
{
    public class AnimalRegistry
    {
        private AnimalRepository _repository = new AnimalRepository();

        public void AddAnimal(Animal animal)
        {
            _repository.AddAnimal(animal);
            Console.WriteLine($"{animal.Name} has been added to the registry.");
        }

        public Animal GetAnimalByName(string name)
        {
            foreach (Animal animal in _repository.GetAllAnimals())
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
            foreach (var animal in _repository.GetAllAnimals())
            {
                Console.WriteLine($"{animal.Name} was born on {animal.BirthDate.ToShortDateString()}");
            }
        }

        public int GetTotalAnimalsCount()
        {
            return _repository.GetAllAnimals().Count;
        }
        public void TeachAnimalNewCommand(string name, string newCommand)
        {
            var animals = _repository.GetAllAnimals();
            var animal = animals.Find(a => a.Name == name);

            if (animal != null)
            {
                _repository.TeachNewCommand(animal.Id, newCommand);
                Console.WriteLine($"Animal {name} has learned a new command: {newCommand}");
            }
            else
            {
                Console.WriteLine("Animal not found.");
            }
        }
    }

}
