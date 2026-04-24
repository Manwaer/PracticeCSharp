namespace Task4
{
    class Program
    {
        static void Main()
        {
            ClimateControl system = new ClimateControl();

            ICooler coolerLink = system;
            coolerLink.AdjustTemperature(5);

            IHeater heaterLink = system;
            heaterLink.AdjustTemperature(10);
        }
    }
}