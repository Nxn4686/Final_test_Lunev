using MySql.Data.MySqlClient;

namespace AnimalRegistry
{
    public class AnimalRepository
    {
        private string _connectionString = "Server=localhost;Database=human_friends;User ID=root;Password=admin;";

        public void AddAnimal(Animal animal)
        {
            using (MySqlConnection conn = new MySqlConnection(_connectionString))
            {
                conn.Open();
                string query = "INSERT INTO Animals (Name, Type, BirthDate) VALUES (@name, @type, @birthdate)";
                MySqlCommand cmd = new MySqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@name", animal.Name);
                cmd.Parameters.AddWithValue("@type", animal.Type);
                cmd.Parameters.AddWithValue("@birthdate", animal.BirthDate);
                cmd.ExecuteNonQuery();

                int animalId = (int)cmd.LastInsertedId;

                foreach (var command in animal.Commands)
                {
                    query = "INSERT INTO Commands (AnimalId, Command) VALUES (@animalId, @command)";
                    cmd = new MySqlCommand(query, conn);
                    cmd.Parameters.AddWithValue("@animalId", animalId);
                    cmd.Parameters.AddWithValue("@command", command);
                    cmd.ExecuteNonQuery();
                }
            }
        }

        public List<Animal> GetAllAnimals()
        {
            List<Animal> animals = new List<Animal>();

            using (MySqlConnection conn = new MySqlConnection(_connectionString))
            {
                conn.Open();
                string query = "SELECT * FROM Animals";
                MySqlCommand cmd = new MySqlCommand(query, conn);
                MySqlDataReader reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    int id = reader.GetInt32("Id");
                    string name = reader.GetString("Name");
                    string type = reader.GetString("Type");
                    DateTime birthDate = reader.GetDateTime("BirthDate");

                    Animal animal = new Animal(name, birthDate, type)
                    {
                        Id = id
                    };

                    animals.Add(animal);
                }
            }

            return animals;
        }

        public List<string> GetAnimalCommands(int animalId)
        {
            List<string> commands = new List<string>();

            using (MySqlConnection conn = new MySqlConnection(_connectionString))
            {
                conn.Open();
                string query = "SELECT Command FROM Commands WHERE AnimalId = @animalId";
                MySqlCommand cmd = new MySqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@animalId", animalId);
                MySqlDataReader reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    commands.Add(reader.GetString("Command"));
                }
            }

            return commands;
        }
    }

}
