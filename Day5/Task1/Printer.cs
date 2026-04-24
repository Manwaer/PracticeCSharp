namespace Task1
{
    public class Printer : OutputDevice
    {
        public string PrintingType { get; set; }

        public Printer(string model, string printingType) : base(model)
        {
            PrintingType = printingType;
        }

        public override void DisplayInfo()
        {
            Console.WriteLine($"[Принтер] Модель: {Model}, Тип печати: {PrintingType}");
        }
    }
}