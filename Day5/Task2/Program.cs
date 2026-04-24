namespace Task2
{
    class Program
    {
        static void Main()
        {
            Country country = new Country("Беларусь");

            Citizen c1 = new Citizen("Иван");
            Citizen c2 = new Citizen("Анна");
            Citizen c3 = new Citizen("Сергей");
            Citizen c4 = new Citizen("Мария");

            City[] cities = new City[]
            {
                new City("Минск", country, new Citizen[] { c1, c2, c3 }, 10),
                new City("Гродно", country, new Citizen[] { c4 }, 8)
            };

            Console.WriteLine("Демография страны:");
            foreach (var city in cities)
            {
                city.ShowPopulation();
            }
        }
    }
}