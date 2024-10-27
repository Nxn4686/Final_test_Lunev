namespace AnimalRegistry
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            AnimalRegistry registry = new AnimalRegistry();
            bool exit = false;

            while (!exit)
            {
                Console.WriteLine("\n1. Add Animal\n2. Show Animal Commands\n3. Teach Animal Command\n4. Show Animals by Birth Date\n5. Show Total Animals\n6. Exit");
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
                        Console.Write("Enter animal name: ");
                        name = Console.ReadLine();
                        Console.Write("Enter command: ");
                        string command = Console.ReadLine();
                        registry.TeachCommand(name, command);
                        break;
                    case "4":
                        registry.ShowAnimalsByBirthDate();
                        break;
                    case "5":
                        Console.WriteLine($"Total Animals: {registry.GetTotalAnimalsCount()}");
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

        private static void AddAnimalMenu(AnimalRegistry registry)
        {
            Console.WriteLine("1. Dog\n2. Cat\n3. Hamster\n4. Horse\n5. Camel\n6. Donkey");
            Console.Write("Select animal type: ");
            string typeChoice = Console.ReadLine();

            Console.Write("Enter animal name: ");
            string name = Console.ReadLine();
            Console.Write("Enter birth date (yyyy-mm-dd): ");
            DateTime birthDate = DateTime.Parse(Console.ReadLine());

            switch (typeChoice)
            {
                case "1":
                    registry.AddAnimal(new Dog(name, birthDate));
                    break;
                case "2":
                    registry.AddAnimal(new Cat(name, birthDate));
                    break;
                case "3":
                    registry.AddAnimal(new Hamster(name, birthDate));
                    break;
                case "4":
                    registry.AddAnimal(new Horse(name, birthDate));
                    break;
                case "5":
                    registry.AddAnimal(new Camel(name, birthDate));
                    break;
                case "6":
                    registry.AddAnimal(new Donkey(name, birthDate));
                    break;
                default:
                    Console.WriteLine("Invalid animal type.");
                    break;
            }
        }
    }
}
