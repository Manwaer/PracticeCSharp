namespace Task2
{
    public class Infrastructure
    {
        public int UtilityLevel { get; set; }

        public Infrastructure(int level)
        {
            UtilityLevel = level;
        }

        public void Maintenance()
        {
            Console.WriteLine($"Обслуживание инфраструктуры. Уровень: {UtilityLevel}");
        }
    }
}