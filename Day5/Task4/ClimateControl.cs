namespace Task4
{
    public class ClimateControl : ICooler, IHeater
    {
        void ICooler.AdjustTemperature(int degrees)
        {
            Console.WriteLine($"[Охлаждение] Температура понижена на {degrees} градусов.");
        }

        void IHeater.AdjustTemperature(int degrees)
        {
            Console.WriteLine($"[Обогрев] Температура повышена на {degrees} градусов.");
        }
    }
}