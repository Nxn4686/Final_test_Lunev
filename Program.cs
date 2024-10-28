namespace AnimalRegistry
{
    public class Program
    {
        public static void Main(string[] args)
        {
            AnimalRegistry registry = new AnimalRegistry();
            bool exit = false;

            while (!exit)
            {
                Console.WriteLine("\n1. Add Animal\n2. Show Animal Commands\n3. Show Animals by Birth Date\n4. Show Total Animals\n5. Teach Animal New Command\n6. Exit");
                Console.Write("Select an option: ");
                string choice = Console.ReadLine();

                switch (choice)
                {
                    case "1":
                        AddAnimalMenu(registry);
                        break;
                    case "2":
                        Console.Write("Enter animal name: ");
                        string name = Console.ReadLine();
                        registry.ShowAnimalCommands(name);
                        break;
                    case "3":
                        registry.ShowAnimalsByBirthDate();
                        break;
                    case "4":
                        Console.WriteLine($"Total Animals: {registry.GetTotalAnimalsCount()}");
                        break;
                    case "5":
                        TeachNewCommandMenu(registry);
                        break;
                    case "6":
                        exit = true;
                        break;
                    default:
                        Console.WriteLine("Invalid option, try again.");
                        break;
                }
            }
        }

        private static void TeachNewCommandMenu(AnimalRegistry registry)
        {
            Console.Write("Enter animal name: ");
            string name = Console.ReadLine();
            Console.Write("Enter the new command: ");
            string newCommand = Console.ReadLine();

            registry.TeachAnimalNewCommand(name, newCommand);
        }

        private static void AddAnimalMenu(AnimalRegistry registry)
        {
            Console.WriteLine("1. Dog\n2. Cat\n3. Hamster\n4. Horse\n5. Camel\n6. Donkey");
            Console.Write("Select animal type: ");
            string typeChoice = Console.ReadLine();

            Console.Write("Enter animal name: ");
            string name = Console.ReadLine();
            Console.Write("Enter birth date (yyyy-mm-dd): ");
            DateTime birthDate = DateTime.Parse(Console.ReadLine());

            Animal animal = new Animal
            {
                Name = name,
                BirthDate = birthDate,
                Commands = new List<string>()
            };

            switch (typeChoice)
            {
                case "1":
                    animal.Type = "Dog";
                    break;
                case "2":
                    animal.Type = "Cat";
                    break;
                case "3":
                    animal.Type = "Hamster";
                    break;
                case "4":
                    animal.Type = "Horse";
                    break;
                case "5":
                    animal.Type = "Camel";
                    break;
                case "6":
                    animal.Type = "Donkey";
                    break;
                default:
                    Console.WriteLine("Invalid animal type.");
                    return;
            }

            registry.AddAnimal(animal);
        }
    }

}

