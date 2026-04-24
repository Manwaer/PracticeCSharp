namespace Task1
{
    public class Monitor : OutputDevice
    {
        public int RefreshRate { get; set; }

        public Monitor(string model, int refreshRate) : base(model)
        {
            RefreshRate = refreshRate;
        }

        public override void DisplayInfo()
        {
            Console.WriteLine($"[Монитор] Модель: {Model}, Частота обновления: {RefreshRate} Гц");
        }
    }
}