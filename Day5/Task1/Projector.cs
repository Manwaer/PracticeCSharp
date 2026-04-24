namespace Task1
{
    public class Projector : OutputDevice
    {
        public int Lumens { get; set; }

        public Projector(string model, int lumens) : base(model)
        {
            Lumens = lumens;
        }

        public override void DisplayInfo()
        {
            Console.WriteLine($"[Проектор] Модель: {Model}, Яркость: {Lumens} лм");
        }
    }
}