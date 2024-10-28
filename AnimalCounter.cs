namespace AnimalRegistry
{
    public class AnimalCounter
    {
        private static int _count = 0;

        public static void AddAnimal()
        {
            _count++;
        }

        public static int GetCount()
        {
            return _count;
        }
    }
}
