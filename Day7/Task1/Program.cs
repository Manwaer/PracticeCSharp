using Task1;

class Program
{
    static void Main()
    {
        Thermostat thermostat = new Thermostat();

        try
        {
            thermostat.CheckTemperature(85);
            thermostat.CheckTemperature(120);
        }
        catch (OverheatException ex)
        {
            Console.WriteLine($"Поймано исключение: {ex.Message}");
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Общая ошибка: {ex.Message}");
        }
        finally
        {
            Console.WriteLine("Проверка завершена.");
        }
    }
}