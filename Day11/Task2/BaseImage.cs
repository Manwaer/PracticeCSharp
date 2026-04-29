namespace Task2
{
    public class BaseImage : IImage
    {
        public string GetDescription() => "Исходное изображение";
        public string Process() => "Данные: [RawPixels]";
    }
}