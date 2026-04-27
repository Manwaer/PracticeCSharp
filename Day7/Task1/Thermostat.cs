namespace Task1
{
    public class Thermostat
    {
        public string CheckTemperature(int temperature)
        {
            if (temperature > 100)
            {
                throw new OverheatException($"Критический перегрев! Температура {temperature}°C превышает норму.");
            }

            return $"Температура в норме {temperature}";
        }
    }
}