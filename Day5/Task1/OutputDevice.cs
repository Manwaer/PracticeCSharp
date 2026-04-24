namespace Task1
{
    public abstract class OutputDevice
    {
        public string Model { get; set; }

        protected OutputDevice(string model)
        {
            Model = model;
        }

        public abstract void DisplayInfo();
    }
}