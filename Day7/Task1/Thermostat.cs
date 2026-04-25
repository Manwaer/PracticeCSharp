namespace Task1
{
    public class Thermostat
    {
        public void CheckTemperature(int temperature)
        {
            if (temperature > 100)
            {
                throw new OverheatException($"Критический перегрев! Температура {temperature}°C превышает норму.");
            }
            Console.WriteLine($"Температура в норме: {temperature}°C");
        }
    }
}