namespace Task2
{
    public class City
    {
        public string Name { get; set; }
        public Country ParentCountry { get; set; }
        private Citizen[] citizens;
        private Infrastructure infrastructure;

        public City(string name, Country country, Citizen[] externalCitizens, int infraLevel)
        {
            Name = name;
            ParentCountry = country;
            citizens = externalCitizens;
            infrastructure = new Infrastructure(infraLevel);
        }

        public void ShowPopulation()
        {
            Console.WriteLine($"Город: {Name} ({ParentCountry.Name}). Жителей: {citizens.Length}");
        }
    }
}