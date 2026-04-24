namespace Task1
{
    class Program
    {
        static void Main()
        {
            OutputDevice[] devices = new OutputDevice[]
            {
                new Monitor("Samsung Odyssey", 240),
                new Printer("Canon PIXMA", "Струйный"),
                new Projector("BenQ TK850", 3000)
            };

            Console.WriteLine("Список устройств вывода:");
            
            foreach (var device in devices)
            {
                device.DisplayInfo();
            }
        }
    }
}